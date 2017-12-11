import React, { Component } from 'react';


export default class Display extends Component {


  render() {

    const displayData = this.props.data.map((data, i) => {
      return (
        <article className='data' key={i}>
          <h4>{data.name}</h4>
          <p>{data.id}</p>
          <p>MORE DATA</p>
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
