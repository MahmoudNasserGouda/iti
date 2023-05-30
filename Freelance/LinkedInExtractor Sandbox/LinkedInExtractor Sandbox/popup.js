document.addEventListener('DOMContentLoaded', function() {
  var userKeyInput = document.getElementById('userKey');

  // Load the stored key
  chrome.storage.sync.get('userKey', function(data) {
    userKeyInput.value = data.userKey || '';
  });

  // Store the key when the input is changed
  userKeyInput.addEventListener('input', function() {
    chrome.storage.sync.set({userKey: userKeyInput.value}, function() {
      console.log('User key is stored in Chrome storage.');
    });
  });
});
