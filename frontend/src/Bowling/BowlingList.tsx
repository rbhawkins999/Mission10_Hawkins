//importing the correct things to be able to use these abilities
import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';

//creating the bowlingList function with arrays
function BowlingList() {
  const [bowlingData, setBowlingData] = useState<Bowler[]>([]);

  //getting the api data
  useEffect(() => {
    const fetchBowlingData = async () => {
      const rsp = await fetch('http://localhost:5154/BowlingLeague');
      const b = await rsp.json();
      setBowlingData(b);
    };
    fetchBowlingData();
  }, []);

  //returning the table with the correct information from the API
  return (
    <>
      <div className="row">
        <h4 className="text-center">Bowling People</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlingData.map((b) => (
            <tr key={b.bowlerId}>
              <td>
                {b.bowlerFirstName} {b.bowlerMiddleInit} {b.bowlerLastName}
              </td>
              <td>{b.teamName}</td>
              <td>
                {b.bowlerAddress}, {b.bowlerCity}, {b.bowlerState},{' '}
                {b.bowlerZip}
              </td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

//allowing App.tsx to use this function
export default BowlingList;
