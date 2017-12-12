import React, { Component } from 'react';
import { putAssets } from '../services/APIService'

class Form extends Component {

  submitForm(e, data) {
    e.preventDefault();
    let response = putAssets(data)
    let newData = Object.assign({}, data, response)
    this.props.updateState(newData)
    // e.preventDefault();
    // putAssets(data)
    // .then(response => {
    //   let newData = Object.assign({}, data, response);
    //   this.props.updateState(newData);
    // })
  }

  render() {
    return (
      <form className="form">
        <label>
          Name
          <input
            ref={(input) => { this.name = input }}
            type="text"
          />
        </label>

        <button
          type="submit"
          onClick={(e) => this.submitForm(e, {
            name: this.name.value,
          })}
        >
            Save
        </button>
      </form>
    );
  }
}


export default Form;
