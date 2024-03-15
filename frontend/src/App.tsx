import React from 'react';
//import logo from './logo.svg';
import './App.css';
import BowlingList from './Bowling/BowlingList';

function Heading() {
  return (
    <h1>
      Welcome to this Bowling Website. See some sweet information about some
      bowling peeps!
    </h1>
  );
}

function App() {
  return (
    <div className="App">
      <Heading />
      <BowlingList />
    </div>
  );
}

export default App;
