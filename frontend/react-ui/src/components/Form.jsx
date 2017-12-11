import React, { Component } from 'react';


class Form extends Component {

  submitForm(data) {
    console.log(data)
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
