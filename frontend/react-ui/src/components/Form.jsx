import React, { Component } from 'react';
import { putAssets } from '../services/APIService'

class Form extends Component {

  submitForm(data) {
    putAssets(data)
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
          onClick={(e) => this.submitForm({
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
