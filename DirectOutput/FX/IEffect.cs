﻿using System;
using DirectOutput.General.Generic;
using DirectOutput.Table;
namespace DirectOutput.FX
{

    /// <summary>
    /// Common interface for all effects.<br/>
    /// If a new effect is implemented it is best to inherit from the abstract class Effect which does also inherit IEffect.<br/>
    /// All classes inheriting IEffect mist be XMLSerializeable.
    /// </summary>
    public interface IEffect:INamedItem
    {

        /// <summary>
        /// Execute triggers the effect for the given TableElement.
        /// </summary>
        /// <param name="TableElementData">TableElementData object for the TableElement which has triggered the effect.</param>
        void Trigger(TableElementData TableElementData);


        /// <summary>
        /// Init must do all necessary initialization work after the IEffect object has been instanciated.
        /// </summary>
        void Init(Pinball Pinball);


        /// <summary>
        /// Finish must do all necessary cleanupwork before a IEffect object is discarded.
        /// </summary>
        void Finish();


        /// <summary>
        /// Name of the effect.<br/>
        /// Be sure to fire the NameChanged event if the name of the object gets changed. The abstract Effect class does already implement this property and the required NameChanged event.
        /// </summary>
        new string Name { get; set; }
        
        /// <summary>
        /// This event must be fired after the Name property of a IEffect object has changed.
        /// </summary>
        new event EventHandler<NameChangeEventArgs> AfterNameChanged;

        /// <summary>
        /// This event must be fired before the Name property of a IEffect object is changed.
        /// </summary>
        new event EventHandler<NameChangeEventArgs> BeforeNameChange;

    }
}
