using UnityEngine;

[CreateAssetMenu(fileName = "Player Stats", menuName = " Player Stats")]
public class PlayerStats : ScriptableObject
{
    [Header("Player Details")]
    public string playerName;
    public string playerDob;
    public string country;
    public string gender;

    [Header("Results")]
    public int played;
    public int wins;
    public int loses;

    [Header("Ball Position on Court")]
    public int miniCourtForehand;
    public int miniCourtBackhand;
    public int miniCourtCenter;
    public int baselineForehand;
    public int baselineBackhand;
    public int baselineCenter;
    public int miniCourtForehandAlley;
    public int miniCourtBackhandAlley;
    public int baselineForehandAlley;
    public int baselineBackhandAlley;

    [Header("GroundStrokes")]
    public int winners = 0;
    public int forehandWinners;
    public int backhandWinners;
    public int unforcedErrors;
    public int forehandUnforcedErrors;
    public int backhandUnforcedErrors;
    public int forcedErrors;
    public int forehandForcedErrors;
    public int backhandForcedErrors;
    public int numberOfshots;
    public int longestRally;
    public int shortestRally;

    [Header ("Serve")]
    public int pointsWonOnServe;
    public float firstServeInPercentage;
    public float secondServeInPercentage;
    public int aces;
    public int doubleFaults;
    public int unreturnableServes;
    
    [Header ("Return")]
    public int recievingPointsWon;
    public int recievingWinners;
    public int forehandReceivingWinners;
    public int backhandReceivingWinners;
    public int recievingUnforcedErrors;
    public int forehandReceivingUnforcedErrors;
    public int backhandReceivingUnforcedErrors;

    [Header("Net")]
    public int netPointsWon;
    public int winnersAtNet;
    public int forehandVolleyWinner;
    public int backhandVolleyWinner;
    public int forehandDriveVolleyWinner;
    public int backhandDriveVolleyWinner;
    public int OverheadWinner;
    public int unforcedErrorsAtNet;
    public int forehandVolleyUnforcedErrors;
    public int backhandVolleyUnforcedErrors;
    public int forehandDriveVolleyUnforcedErrors;
    public int backhandDriveVolleyUnforcedErrors;
    public int OverheadUnforcedErrors;
    public int forcedErrorsAtNet;
    public int forehandVolleyforcedErrors;
    public int backhandVolleyforcedErrors;
    public int forehandDriveVolleyforcedErrors;
    public int backhandDriveVolleyforcedErrors;
    public int OverheadforcedErrors;


    [Header("Dropshots")]
    public int dropshotPointsWon;
    public int forehandDropWinners;
    public int backhandDropWinners;
    public int dropshotUnforcedErrors;
    public int forehandDropUnforcedErrors;
    public int backhandDropUnforcedErrors;
    public int dropshotforcedErrors;
    public int forehandDropforcedErrors;
    public int backhandDropforcedErrors;
    public int dropVolleyWinners;
    public int forehandDropVolleyWinners;
    public int backhandDropVolleyWinners;
    public int forehandDropVolleyUnforcedErrors;
    public int backhandDropVolleyUnforcedErrors;
    public int forehandDropVolleyforcedErrors;
    public int backhandDropVolleyforcedErrors;

    [Header("Slice")]
    public float slicetoTopspinPercentage;
    public int sliceWinners;
    public int forehandSliceWinners;
    public int backhandSliceWinners;
    public int sliceUnforcedErrors;
    public int forehandSliceUnforcedErrors;
    public int backhandSliceUnforcedErrors;
    public int sliceforcedErrors;
    public int forehandSliceforcedErrors;
    public int backhandSliceforcedErrors;

    [Header("Misc")]
    public int netCordPoints;
    public int netCordWinners;
    public int netCordReturns;
    public int netCordPointsWon;
    public int netCordPointsLost;

    [Header("Total Points")]
    public int totalPointsWon;
}
