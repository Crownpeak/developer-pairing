export const getBaseUrl = () => {
  return 'http://localhost:63477/api/'
}

export const getAssets = () => {
  fetch(`${this.getBaseUrl}/Assets`)
    .then(response => response.json()
    .then(response => { return response }));
}

export const putAssets = (data) =>  {
  fetch(`${this.getBaseUrl}/Assets`, {
    method: 'put',
    body: data
  }).then(response => { return response.json() });
}

export const deleteAssets = (assetId) => {
  fetch(`${this.getBaseUrl}/Assets/${assetId}`, {
    method: 'delete',
  }).then(response => response.json()
    .then(response => { return response }));
}
