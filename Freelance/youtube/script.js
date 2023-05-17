// load the YouTube Data API
gapi.load('client', init);

// initialize the API client and start updating the channel list
async function init() {
  await gapi.client.init({
    apiKey: 'AIzaSyBF1W42diiq0iZGvM69gQ_2W5XVzg0XXoQ',
    discoveryDocs: ['https://www.googleapis.com/discovery/v1/apis/youtube/v3/rest'],
  });
  updateChannels();
}

const channelList = document.getElementById('channel-list');

// function to fetch the top 100 subscribed channels from the YouTube API
async function fetchTopChannels() {
  const response = await gapi.client.youtube.channels.list({
    part: 'snippet,statistics',
    maxResults: 100,
    order: 'subscriberCount',
    type: 'channel',
    id:['UCq-Fj5jknLsUf-MWSy4_brA','UCbCmjCuTUZos6Inko4u57UQ','UCpEhnqL0y41EpW2TvWAHD7Q','UCX6OQ3DkcsbYNE6H8uQQuVA','UC-lHJZR3Gqxm24_Vd_AJ5Yw','UCk8GzjMOrta8yxDcKfylJYw','UCJplp5SjeGSdVdwsfb9Q7lQ','UCvlE5gTbOvjiolFlEm-c_Ow','UCJ5v_MCY6GNUBTO8-D3XoAg','UCFFbwnve3yF62-tVXkTyHqg','UCOmHUn--16B90oW2L6FRR3A'],
  });
  return response.result.items;
}



// function to display the channels on the web page
function displayChannels(channels) {
  channels.forEach((channel, index) => {
    const row = document.createElement('tr');
    row.innerHTML = `
      <td>${index + 1}</td>
      <td>${channel.snippet.title}</td>
      <td>${channel.statistics.subscriberCount}</td>
    `;
    channelList.appendChild(row);
  });
}

// function to update the channel list every 10 minutes
async function updateChannels() {
  channelList.innerHTML = ''; // clear the existing list
  const channels = await fetchTopChannels();
  displayChannels(channels);
  setTimeout(updateChannels, 600000); // update every 10 minutes
}