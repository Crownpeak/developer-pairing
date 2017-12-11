export const getBaseUrl = () => {
  return 'http://localhost:63477/api/'
}

export const getAssets = () => {
  return fetch('/api/Assets')
    .then(response => response.json());
}

export const putAssets = (data) =>  {
  return fetch(`${this.getBaseUrl}/Assets`, {
    method: 'put',
    body: data
  }).then(response => { response.json() });
}

export const deleteAssets = (assetId) => {
  return fetch(`${this.getBaseUrl}/Assets/${assetId}`, {
    method: 'delete',
  }).then(response => response.json());
}
