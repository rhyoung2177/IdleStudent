using System;
using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using UnityEngine;

public class TitleLoading : MonoBehaviour
{
    MySqlConnection sqlconn = null;
    private string sqlDBip = "127.0.0.1";
    private string sqlDBname = "firsttest";
    private string sqlDBid = "root";
    private string sqlDBpw = "fb1180601*";
    void Awake()
    {
        sqlConnect();
    }
    
    private void sqlConnect()
    {
        //DB정보 입력
        string sqlDatabase = "Server=" + sqlDBip + ";Database=" + sqlDBname + ";UserId=" + sqlDBid + ";Password=" + sqlDBpw + "";

        //접속 확인하기
        try
        {
            sqlconn = new MySqlConnection(sqlDatabase);
            sqlconn.Open();
            Debug.Log("Connect to Sql : " + sqlconn.State); 

            var tableItem = SearchID();
            
            // 본인 UUID가 없으면 DB에 생성 요청
            if (!tableItem.Item2)
                MakeID(tableItem.Item1);

            // sqldisConnect();
        }
        catch (Exception msg)
        {
            Debug.Log(msg); 
        }
    }
    
    private void sqldisConnect()
    {
        sqlconn.Close();
        Debug.Log("Disconnect to Sql : " + sqlconn.State); 
    }

    private void MakeID(int index)
    {
        if (sqlconn != null)
        {
            string insertsql = "INSERT INTO info(uuid,userindex) VALUES('header1', 0)";
            //string insertsql = "INSERT INTO info(uuid, userindex) VALUES('asdf', 1)";
            try
            {
                MySqlCommand command = new MySqlCommand(insertsql, sqlconn);

                if (command.ExecuteNonQuery() == 1)
                    Debug.Log($"{SystemInfo.deviceUniqueIdentifier}, {index} Insert Success");
                else
                    Debug.Log($"{SystemInfo.deviceUniqueIdentifier}, {index} Insert Failed");

            }
            catch (Exception ex)
            {
                Debug.Log("Insert Failed");
                Console.WriteLine(ex.ToString());
            }
        }
    }

    private (int, bool) SearchID()
    {
        string sql = "SELECT * FROM info";
        List<string> uidTable = new List<string>();
        
        MySqlCommand cmd = new MySqlCommand(sql, sqlconn);
        MySqlDataReader table = cmd.ExecuteReader();
        
        while (table.Read())
            uidTable.Add($"{table["uuid"]}");

        Debug.Log($"ID Count : {uidTable.Count}");
        
        foreach (var str in uidTable)
        {
            if (SystemInfo.deviceUniqueIdentifier == str)
                return (uidTable.Count, true);
        }

        return (uidTable.Count, false);
    }
}
