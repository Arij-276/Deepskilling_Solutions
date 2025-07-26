// src/App.js
import React from 'react';
import Home from './Components/Home';
import About from './Components/About';
import Contact from './Components/Contact';
import Posts from './Posts';    // Import Posts component
import './mystyle.css';

function App() {
  return (
    <div className="container">
      <Home />
      <About />
      <Contact />
      <Posts />  {/* Render Posts component */}
    </div>
  );
}

export default App;
