﻿/*
** LocomotionInformation.cs for Unity-Character-Mechanism
**
** Made by Antoine MOREL
**
** Started on  Jan 08 2019 Antoine MOREL
** Last update Jan 09 2019 Antoine MOREL
** 
** Copyright (c) 2018 - 2019 All Rights Reserved
*/

using System;
using CharacterMechanism.Normal.Attribute;
using UnityEngine;

namespace CharacterMechanism.Normal.Information.Locomotion
{
    /// <inheritdoc/>
    /// <summary>
    /// Class containing all the locomotion information
    /// </summary>
    [Serializable]
    public sealed class LocomotionInformation : IInformation
    {
        ///////////////////////////////
        ////////// Attribute //////////
        ///////////////////////////////
        
        [ReadOnly] public Vector3 MovementDirection = Vector3.zero;
        [ReadOnly] public bool ShouldJump = false;
        [ReadOnly] public bool ShouldRun = false;
        
        ////////////////////////////
        ////////// Method //////////
        ////////////////////////////

        public void Reset()
        {
            MovementDirection.Set(0f, 0f, 0f);
            ShouldJump = false;
            ShouldRun = false;
        }
    }
}