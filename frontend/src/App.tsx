import React from 'react';
//import logo from './logo.svg';
import './App.css';
import BowlingList from './Bowling/BowlingList';

//heading function per requirement that introduces the user to the site
function Heading() {
  return (
    <h1>
      Welcome to this Bowling Website. See some sweet information about some
      bowling peeps!
    </h1>
  );
}

//is called for the app to ru and includes the heading function and BowlingList to give the table data
function App() {
  return (
    <div className="App">
      <Heading />
      <BowlingList />
    </div>
  );
}

export default App;
