﻿    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Game : MonoBehaviour {

        public static int gridwidth = 10;
        public static int gridheight = 20;

        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }
        public bool CheckInsideGrid(Vector2 pos)
        {
            return ((int)pos.x >= 0 && (int)pos.x < gridwidth && (int)pos.y >= 0);
        }
        public Vector2 Round (Vector2 pos)
        {
            return new Vector2(Mathf.Round(pos.x), Mathf.Round(pos.y));
        }
    }
