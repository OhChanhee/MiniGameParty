using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using BackEnd;

public class MatchQueueMgr : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }


    private void Update()
    {
        Backend.Match.Poll();
    }
}