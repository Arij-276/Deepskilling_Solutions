import React, { useState } from 'react';

function CalculateScore() {
  const [score1, setScore1] = useState('');
  const [score2, setScore2] = useState('');
  const [total, setTotal] = useState(null);

  const handleCalculate = () => {
    // Parse input and sum the scores
    const s1 = parseFloat(score1) || 0;
    const s2 = parseFloat(score2) || 0;
    setTotal(s1 + s2);
  };

  return (
    <div>
      <h3>Calculate Total Score</h3>
      <input
        type="number"
        value={score1}
        onChange={e => setScore1(e.target.value)}
        placeholder="Enter first score"
      />
      <input
        type="number"
        value={score2}
        onChange={e => setScore2(e.target.value)}
        placeholder="Enter second score"
      />
      <button onClick={handleCalculate}>Calculate</button>
      {total !== null && (
        <div>
          <h4>Total Score: {total}</h4>
        </div>
      )}
    </div>
  );
}

export default CalculateScore;
