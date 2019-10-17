﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Takens
{
    public class ItemGUI : MonoBehaviour
    {
        public Image sprite;
        public ItemType thisItem;


        public void Update()
        {
            sprite.enabled  = (Inventory.main.hasItem(thisItem));
        }
    }
}