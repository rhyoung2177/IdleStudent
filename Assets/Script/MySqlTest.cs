using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

public class MySqlTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        sqlConnect();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    MySqlConnection sqlconn = null;
    private string sqlDBip = "127.0.0.1";
    private string sqlDBname = "firsttest";
    private string sqlDBid = "root";
    private string sqlDBpw = "autoset";

    private void sqlConnect()
    {
        //DB정보 입력
        string sqlDatabase = "Server=" + sqlDBip + ";Database=" + sqlDBname + ";UserId=" + sqlDBid + ";Password=" + sqlDBpw + "";

        //접속 확인하기
        try
        {
            Debug.Log(sqlDatabase);
            sqlconn = new MySqlConnection(sqlDatabase);
            sqlconn.Open();
            Debug.Log("SQL의 접속 상태 : " + sqlconn.State); //접속이 되면 OPEN이라고 나타남
        }
        catch (Exception msg)
        {
            Debug.Log(msg); //기타다른오류가 나타나면 오류에 대한 내용이 나타남
        }
    }

    private void sqldisConnect()
    {
        sqlconn.Close();
        Debug.Log("SQL의 접속 상태 : " + sqlconn.State); //접속이 끊기면 Close가 나타남 
    }
}
