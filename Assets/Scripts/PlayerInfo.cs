﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour {

	public static float TotalScore;
	public static float score;
	public static float LastScore;

	public Text ScoreText;
	public Text TotalScoreText;
	public Text LastScoreText;

	// Use this for initialization
	void Start () {
		LastScoreUpdate ();
		score = 0;
		ScoreUpdate();
		TotalScoreUpdate ();
	}
	
	// Update is called once per frame
	void Update () {
		ScoreUpdate ();
	}

	void ScoreUpdate () {
		score += Time.deltaTime;
		ScoreText.text = "Score: " + ((int)(PlayerInfo.score)).ToString ();
	}

	void TotalScoreUpdate(){
		TotalScore += Time.deltaTime;
		TotalScoreText.text = "Total Score: " + ((int)(TotalScore)).ToString ();
	}

	void LastScoreUpdate(){
		LastScore = score;
		LastScoreText.text = "Last Score: " + ((int)(LastScore)).ToString ();
	}

	public static void SaveGameInfo(){
		PlayerPrefs.SetFloat ("SCORE", PlayerInfo.score);
		PlayerPrefs.SetFloat ("TOTALSCORE", PlayerInfo.TotalScore);
	}

	public static void LoadGameInfo(){
		PlayerInfo.score = PlayerPrefs.GetFloat ("SCORE");
		PlayerInfo.TotalScore = PlayerPrefs.GetFloat ("TOTALSCORE");
	}
}