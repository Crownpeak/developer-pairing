function getAssets() {
  fetch('/api/Assets')
    .then(response => response.json()
    .then(response => { return response }));
}

function putAssets() {
  fetch('api/Assets', {
    method: 'put'
  }).then(response => { return response.json() });
}
