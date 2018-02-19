
export const getAssets = () => {
  return fetch('/api/assets')
    .then(response => response.json());
}

// let stubId = 10;
export const putAssets = (data) =>  {
  // stubId += 1;
  // return { id: stubId }
  return fetch(`/api/assets`, {
    method: 'PUT',
    body: JSON.stringify(data)
  })
    .then(response => { response.json() });
}

export const deleteAssets = (assetId) => {
  // return { id: assetId }
  return fetch(`$/api/assets/${assetId}`, {
    method: 'DELETE',
  })
    .then(response => response.json());
}
