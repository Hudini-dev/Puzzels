using Newtonsoft.Json;
using System;
using System.ComponentModel;
using UnityEngine;

namespace Assets.Scripts.Data.Builder
{
    [Serializable]
    public class CardData
    {
        [JsonIgnore]
        public Sprite Front;
        [DefaultValue("")]
        public string Expansion;
        public EnhancementData Enhancements;

        [JsonIgnore]
        private string _id;

        public string Id
        {
            get
            {
                if(Front == null)
                {
                    return "";
                }
                else
                {
                    return Front.name.Split('_')[0];
                }
            }
            set
            {
                _id = value;
            }
        }


    }
}
