export const getBaseUrl = () => {
  return 'http://localhost:63477/api/'
}

export const getAssets = () => {
  fetch('/Assets')
    .then(response => response.json()
    .then(response => { return response }));
}

export const putAssets = () =>  {
  fetch(`${this.getBaseUrl}/Assets`, {
    method: 'put'
  }).then(response => { return response.json() });
}

