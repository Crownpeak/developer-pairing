
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


const stubData = [
  {name: "Sam", id: 1},
  {name: "Sam", id: 2},
  {name: "Sam", id: 3},
  {name: "Sam", id: 4}
]
