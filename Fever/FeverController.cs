using IPA.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Fever
{
    /// <summary>
    /// Monobehaviours (scripts) are added to GameObjects.
    /// For a full list of Messages a Monobehaviour can receive from the game, see https://docs.unity3d.com/ScriptReference/MonoBehaviour.html.
    /// </summary>
    public class FeverController : MonoBehaviour, IInitializable
    {
        [Inject]
        ScoreController controller;
        [Inject]
        FeverModeUIPanel panel;

        public void Initialize()
        {
            try {
                this.controller.SetField("_feverModeRequiredCombo", 20);
                Plugin.Log.Debug($"{panel.GetField<RectTransform, FeverModeUIPanel>("_feverBGTextRectTransform").sizeDelta}");
            }
            catch (Exception e) {
                Plugin.Log.Error(e);
            }
        }

        // These methods are automatically called by Unity, you should remove any you aren't using.
        #region Monobehaviour Messages
        /// <summary>
        /// Only ever called once, mainly used to initialize variables.
        /// </summary>
        private void Awake()
        {
            // For this particular MonoBehaviour, we only want one instance to exist at any time, so store a reference to it in a static property
            //   and destroy any that are created while one already exists.
            Plugin.Log?.Debug($"{name}: Awake()");
        }
        /// <summary>
        /// Called when the script is being destroyed.
        /// </summary>
        private void OnDestroy()
        {
            Plugin.Log?.Debug($"{name}: OnDestroy()");
        }
        #endregion
    }
}
