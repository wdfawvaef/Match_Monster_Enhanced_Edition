﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTask {
    public int taskType;
    public int taskData;
    public int award;
    public GameTask(int taskType) {
        this.taskType = taskType;
    }

    public string[] TaskInfo() {
        //消灭任务
        if (taskType==0) {
            int data = Random.Range(1,3) * 100;
            return new[] {"0", "任务:消灭" + data + "只怪兽",data+"", data / 20 + ""};
        }
        //分数任务
        else {
            int data = Random.Range(10, 20) * 100;
            return new[] { "1","分数达到" + data + "分", data + "", "" +data / 200  };
        }
    }
}
