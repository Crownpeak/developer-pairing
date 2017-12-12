
export const getAssets = () => {
  return fetch('/api/Assets')
    .then(response => response.json());
}

export const putAssets = (data) =>  {
  // return { id: 10 }
  return fetch(`/api/Assets`, {
    method: 'PUT',
    body: JSON.stringify(data)
  })
    .then(response => { response.json() });
}

export const deleteAssets = (assetId) => {
  // return { id: assetId }
  return fetch(`$/api/Assets/${assetId}`, {
    method: 'DELETE',
  })
    .then(response => response.json());
}
