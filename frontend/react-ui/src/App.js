import React, { Component } from 'react';
import Header from './components/Header.jsx';
import Form from './components/Form.jsx';
import Display from './components/Display.jsx';
import { getAssets } from './services/APIService'
import './App.css';

const stubData = [
  {name: "Sam", id: 1},
  {name: "Sam", id: 2},
  {name: "Sam", id: 3},
  {name: "Sam", id: 4}
]

export default class App extends Component {
  constructor() {
    super()
    this.state = {
      appData: []
    }
    this.updateState = this.updateState.bind(this)
    this.deleteAsset = this.deleteAsset.bind(this)
  }

  componentWillMount() {
    // this.setState({ appData: stubData })
    getAssets()
      .then(appData => this.setState({ appData }));
  }

  updateState(data) {
    let newData = this.state.appData;
    newData.push(data);
    this.setState({ appData: newData });
  }

  deleteAsset(assetId) {
    let newData = this.state.appData.filter(asset => asset.id !== assetId);
    this.setState({ appData: newData });
  }

  render() {
    return (
      <div className="App">
        <Header />
        <Form updateState={this.updateState}/>
        <Display
          data={this.state.appData}
          deleteAsset={this.deleteAsset}
        />
      </div>
    );
  }
}
