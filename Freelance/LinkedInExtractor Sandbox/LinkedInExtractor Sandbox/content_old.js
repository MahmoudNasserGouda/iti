window.addEventListener('load', function() {
  if (window.location.href.startsWith("https://www.linkedin.com/in/")) {
    let observer = new MutationObserver(addButton);
    observer.observe(document, { childList: true, subtree: true });

    function addButton() {
      let buttonBar = document.querySelector('.pv-top-card-v2-ctas > div');

      if (buttonBar) {
        let newButton = document.createElement('button');
        newButton.innerHTML = 'Loading...';
        newButton.style.fontStyle = 'normal';
        newButton.style.borderColor = '#0073b1';
        newButton.style.color = '#0073b1';
        newButton.id = 'showProfile';
        newButton.className = 'artdeco-button artdeco-button--2 artdeco-button--secondary ember-view';
        newButton.disabled = true;

        let slider = document.createElement('div');
        slider.id = 'slider';
        slider.style.position = 'fixed';
        slider.style.right = '0';
        slider.style.top = '0';
        slider.style.width = '35%';
        slider.style.height = '100%';
        slider.style.backgroundColor = '#fff';
        slider.style.border = '0';
        slider.style.padding = '10px';
        slider.style.zIndex = '9999';
        slider.style.overflow = 'auto';
        slider.style.transition = 'all 0.5s';
        slider.style.boxShadow = '0px 0px 10px rgba(0, 0, 0, 0.5)';
        slider.style.transform = 'translateX(100%)';

        let iframe = document.createElement('iframe');
        iframe.frameBorder = '0';
        slider.appendChild(iframe);

        // Create a close button
        let closeButton = document.createElement('button');
        closeButton.style.position = 'absolute';
        closeButton.style.left = '3px';
        closeButton.style.top = '3px';
        closeButton.style.zIndex = '10000';
        closeButton.style.padding = '3px';
        closeButton.style.border = 'none';
        closeButton.style.backgroundColor = 'transparent';
        closeButton.style.cursor = 'pointer';

        // Create an img element for the icon
        let closeIcon = document.createElement('img');
        closeIcon.src = 'https://icons.veryicon.com/png/o/miscellaneous/rongyiguang/pop-up-close-1.png';
        closeIcon.style.width = '15px';
        closeIcon.style.height = '15px';

        // Append the icon to the close button
        closeButton.appendChild(closeIcon);

        // Add a click event listener to the close button to hide the slider
        closeButton.addEventListener('click', function() {
          slider.style.transform = 'translateX(100%)';
        });

        // Append the close button to the slider
        slider.appendChild(closeButton);

        Promise.all([
          extractFullName(),
          extractAbout(),
          extractExperiences(),
          extractHeadline(),
          extractCurrentURL(),
          extractContactInfoSourceCode().then(sourceCode => {
            let cleanedSourceCode = removeMetaTags(sourceCode);
            return extractPhoneEmail(cleanedSourceCode);
          })
        ]).then(([fullName, about, experiences, headline, url, contactInfo]) => {
          newButton.innerHTML = 'AI Headhunter';
          newButton.disabled = false;

          console.log('fullName:', fullName);
          console.log('about:', about);
          console.log('headline:', headline);
          console.log('url:', url);
          console.log('contactInfo:', contactInfo);
          console.log('experiences:', experiences);

          iframe.src = 'https://flexstaff.net/version-test/extension/?debug_mode=true&url=' + url;
          iframe.style.width = '100%';
          iframe.style.height = '99%';
          slider.appendChild(iframe);

          // Call addProfile when all data is loaded
          addProfile(fullName, about, experiences, headline, url, contactInfo.phone, contactInfo.email)
            .then(status => console.log(`Profile added, response status: ${status}`))
            .catch(err => console.error(err));
        });

        newButton.addEventListener('click', function() {
          if (slider.style.transform === 'translateX(100%)') {
            slider.style.transform = 'translateX(0)';
          } else {
            slider.style.transform = 'translateX(100%)';
          }
        });

        buttonBar.appendChild(newButton);
        document.body.appendChild(slider);

        observer.disconnect();
      }
    }
    addButton();
  }
});


// Your extract functions remain the same...

// Updated addProfile function with mobile and email parameters
function addProfile(fullName, about, experiences, headline, url, mobile, email) {
  return new Promise((resolve, reject) => {
    // Prepare the request parameters
    let requestUrl = 'https://flexstaff.net/version-test/api/1.1/wf/create_profile';
    let headers = {
      'Authorization': 'Bearer b7dffcdeac6baa8a2023b520d0c6dccc',
      'Content-Type': 'application/json',
    };
    let params = {
      'url': url,
      'about': about,
      'experiences': experiences,
      'headline': headline,
      'name': fullName,
      'mobile': mobile, // Add mobile parameter
      'email': email // Add email parameter
    };

    let paramsJson = JSON.stringify(params);

    // Make the API request
    fetch(requestUrl, {
      method: 'POST',
      headers: headers,
      body: paramsJson
    })
      .then(response => {
        if (response.ok) {
          resolve(response.status);
        } else if (response.status === 400) {
          response.json().then(errorData => {
            console.error('Error updating records:', errorData);
            reject('Error updating records: ' + JSON.stringify(errorData));
          });
        } else {
          throw new Error('Request failed with status: ' + response.status);
        }
      })
      .catch(error => {
        console.error('Error updating records:', error);
        reject('Error updating records: ' + error);
      });
  });
}



// Extract functions...
function extractFullName() {
  let nameElement = document.querySelector('h1.text-heading-xlarge');
  if (nameElement) {
    let fullName = nameElement.innerText;
    return `${fullName}`;
  }
  return '';
}

function extractCurrentURL() {
      return window.location.href;
}

function extractHeadline() {
  let headlineElement = document.querySelector('.text-body-medium');
  if (headlineElement) {
    let headline = headlineElement.innerText;
    return `${headline}`;
  }
  return '';
}

function extractAbout() {
  let aboutElement = document.querySelector('.inline-show-more-text.full-width span[aria-hidden="true"]');
  if (aboutElement) {
    let about = aboutElement.innerText;
    return `${about}`;
  }
  return '';
}



// Extract contact info source code function
async function extractContactInfoSourceCode() {
  // Find the contact info link element
  let contactInfoLinkElement = document.querySelector('a[id="top-card-text-details-contact-info"]');

  // Extract the relative URL
  let relativeUrl = contactInfoLinkElement ? contactInfoLinkElement.getAttribute('href') : '';

  // Make a request to the relative URL
  let response = await fetch(`https://www.linkedin.com${relativeUrl}`);

  // Get the source code as text
  let sourceCode = await response.text();

  // Return the source code
  return sourceCode;
}

// Escape HTML function
function escapeHtml(unsafe) {
  return unsafe
    .replace(/&/g, "&amp;")
    .replace(/</g, "&lt;")
    .replace(/>/g, "&gt;")
    .replace(/"/g, "&quot;")
    .replace(/'/g, "&#039;");
}

// Remove meta tags function
function removeMetaTags(sourceCode) {
  return sourceCode.replace(/<meta.*?>/g, '');
}

// Extract phone and email function
function extractPhoneEmail(sourceCode) {
  let phoneRegex = /\+(?:\d\s*){8,}/g;
  let emailRegex = /\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b/g;

  let phoneMatches = sourceCode.match(phoneRegex);
  let emailMatches = sourceCode.match(emailRegex);

  return {
    phone: phoneMatches ? phoneMatches[0] : '',
    email: emailMatches ? emailMatches[0] : ''
  };
}


function getCleanText(text) {
    const regexRemoveMultipleSpaces = / +/g
    const regexRemoveLineBreaks = /(\r\n\t|\n|\r\t)/gm

    if (!text) return null

    const cleanText = text.toString()
      .replace(regexRemoveLineBreaks, '')
      .replace(regexRemoveMultipleSpaces, ' ')
      .replace('...', '')
      .replace('See more', '')
      .replace('See less', '')
      .trim()

    return cleanText
}

function extractExperiences() {
  let experiences = '';
  let experienceAnchor = document.querySelector('#experience');

  if (experienceAnchor) {
    let experienceSection = experienceAnchor.closest('section');
    let experienceList = experienceSection.querySelectorAll('.pvs-entity');

    experienceList.forEach((experience) => {
      let titleElement = experience.querySelector('.mr1.t-bold') || experience.querySelector('.hoverable-link-text.t-bold');
      let dateElement = experience.querySelector('.t-14.t-normal.t-black--light');
      let locationElement = experience.querySelector('.t-16.t-black--light.t-normal');
      let descriptionElement = experience.querySelector('.pv-shared-text-with-see-more');
      let companyElement = experience.querySelector('a');

      let title = titleElement ? getCleanText(titleElement.textContent) : '';
      let date = dateElement ? getCleanText(dateElement.textContent) : '';
      let description = descriptionElement ? getCleanText(descriptionElement.textContent) : '';
      let location = locationElement ? getCleanText(locationElement.textContent) : '';
      let company = companyElement ? companyElement.getAttribute('href') : ''; //Get the href attribute of the a tag as the company name.

      experiences += `Title: ${title}\nCompany: ${company}\nDate: ${date}\nDescription: ${description}\nLocation: ${location}\n\n`;
    });
  }

  return experiences;
}
