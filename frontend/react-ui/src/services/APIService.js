
export const getAssets = () => {
  return stubData
  // fetch('/api/Assets')
  // .then(response => response.json()
  // .then(response => { return response }));
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


const stubData = [
  {name: "Sam", id: 1},
  {name: "Sam", id: 2},
  {name: "Sam", id: 3},
  {name: "Sam", id: 4}
]
