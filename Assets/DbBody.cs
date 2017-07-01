using UnityEngine;
using System.Collections;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
public class DbBody : MonoBehaviour
{
	public String BodyTable;
	public String score1;
	public String score;
	public static String[] scoreArray1 = new string[7];
	public String a1;
	public String a2;
	public String a3;
	public String a4;
	public String a5;
	public String a6;
	// Use this for initialization
	
	public void Start()
	{
		//SendData();
	}
	
	public void SendData()
	{
		string strConn = "Server=localhost;Database=deusProject;Uid=root;Pwd=d7623881;";
		MySqlConnection conn = new MySqlConnection(strConn);
		InsertUpdate();
		//SelectUsingReader();
		conn.Close();
	}
	public void InsertUpdate()
	{
		string strConn = "Server=localhost;Database=deusProject;Uid=root;Pwd=d7623881;";
		//InsertUpdate into armgame(Score) values (' ');
		string a = BodyTable;
		
		string b = score1;  // 개발팀에서 score 주면 받아옴
		string c = "')";
		
		using (MySqlConnection conn = new MySqlConnection(strConn))
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand(a + b + c, conn);
			cmd.ExecuteNonQuery();
		}
	}
	
	public void SelectUsingReader()
	{
		string connStr = "Server=localhost;Database=deusProject;Uid=root;Pwd=d7623881;";
		
		using (MySqlConnection conn = new MySqlConnection(connStr))
		{
			conn.Open();
			
			string sql = "SELECT score FROM bodygame ORDER BY turn_num DESC limit 7";
			//ExecuteReader를 이용하여
			//연결 모드로 데이타 가져오기
			MySqlCommand cmd = new MySqlCommand(sql, conn);
			MySqlDataReader rdr = cmd.ExecuteReader();
			int i=0;
			while(i<7){
				
				rdr.Read();
				scoreArray1[i] = rdr.GetInt32(0).ToString();
				i++;
				
				
			}/*
			rdr.Read();
			a1 = rdr.GetInt32(0).ToString();
			rdr.Read();
			a2 = rdr.GetInt32(0).ToString();
			rdr.Read();
			a3 = rdr.GetInt32(0).ToString();
			rdr.Read();
			a4 = rdr.GetInt32(0).ToString();
			rdr.Read();
			a5 = rdr.GetInt32(0).ToString();
			rdr.Read();
			a6 = rdr.GetInt32(0).ToString();
*/
			
			rdr.Close();
		}
	}
}





