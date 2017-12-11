import React, { Component } from 'react';
import Header from './components/Header.jsx';
import Form from './components/Form.jsx';
import Display from './components/Display.jsx';
import { getAssets } from './services/APIService'
import './App.css';

export default class App extends Component {
  constructor() {
    super()
    this.state = {
      appData: []
    }
  }

  componentWillMount() {
    getAssets().then(response => this.setState({ appData: response}) );
  }

  render() {
    return (
      <div className="App">
        <Header />
        <Form />
        <Display
          data={this.state.appData}
        />
      </div>
    );
  }
}
