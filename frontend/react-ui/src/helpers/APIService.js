function getAssets() {
  fetch('/api/Assets')
    .then(data => data.json()
    .then(data => { return data }));
}


