import React, { Component } from 'react';
import Header from './components/Header.jsx';
import Form from './components/Form.jsx';
import Display from './components/Display.jsx';
import { getAssets } from './services/APIService.js'
import './App.css';

export default class App extends Component {
  constructor() {
    super()
    this.state = {}
  }

  componentWillMount() {
    const data = getAssets();
    this.setState({ appData: data })
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
