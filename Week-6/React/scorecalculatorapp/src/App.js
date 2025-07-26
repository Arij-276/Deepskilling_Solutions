import React from 'react';
import Home from './Components/Home';
import About from './Components/About';
import Contact from './Components/Contact';
import CalculateScore from './Components/CalculateScore';
import './mystyle.css'; // If you want to apply custom styles

function App() {
  return (
    <div className="container">
      <Home />
      <About />
      <Contact />
      <CalculateScore />
    </div>
  );
}

export default App;
