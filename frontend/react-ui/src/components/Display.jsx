import React, { Component } from 'react';
import { deleteAssets } from '../services/APIService'

export default class Display extends Component {

  removeCard(id) {
    // let response = deleteAssets(id)
    // this.props.deleteAsset(id)
    deleteAssets(id)
    .then(response => {
      this.props.deleteAsset(response.id)
    })
  }

  render() {

    const displayData = this.props.data.map((data, i) => {
      return (
        <article className='data' key={i}>
          <h4>{data.name}</h4>
          <p>{data.id}</p>
          <button
            onClick={ () => this.removeCard(data.id) }
          >Delete
          </button>
        </article>
      )
    })

    return (
      <section className='data-container'>
        {displayData}
      </section>
    );
  }
}
