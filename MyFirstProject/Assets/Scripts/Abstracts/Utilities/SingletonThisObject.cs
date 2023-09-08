using MyFirsProjectManagers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFirsProjectAbstractUtilities
{
    public abstract class SingletonThisObject<Manager> : MonoBehaviour
    {
        public static Manager Instance { get; private set; }

        protected void SingletonThisGameObject(Manager entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}
