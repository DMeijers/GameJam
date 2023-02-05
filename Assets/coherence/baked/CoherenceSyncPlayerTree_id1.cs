// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using UnityEngine;
	using Coherence.Toolkit;
	using Coherence.Toolkit.Bindings;
	using Coherence.Entity;
	using Coherence.ProtocolDef;
	using Coherence.Brook;
	using Coherence.Toolkit.Bindings.ValueBindings;
	using Coherence.Toolkit.Bindings.TransformBindings;
	using Coherence.Connection;
	using Coherence.Log;
	using Logger = Coherence.Log.Logger;
	using UnityEngine.Scripting;

	public class Binding_6e41740ccd468754ebce2e5459d93cdd_03988d14_e364_4e85_80f3_85a566ae74c5 : BoolAnimatorParameterBinding
	{
		private UnityEngine.Animator CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Animator)UnityComponent;
		}
		public override string CoherenceComponentName => "PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override bool Value
		{
			get => (bool)(CastedUnityComponent.GetBool(CastedDescriptor.ParameterHash));
			set => CastedUnityComponent.SetBool(CastedDescriptor.ParameterHash, (value));
		}

		protected override bool ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214)coherenceComponent;
			return update.IsMoving;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214)coherenceComponent;
			update.IsMoving = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214();
		}
	}

	public class Binding_6e41740ccd468754ebce2e5459d93cdd_5a5d4943_7ac3_4a7a_8194_f6794894294c : BoolAnimatorParameterBinding
	{
		private UnityEngine.Animator CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Animator)UnityComponent;
		}
		public override string CoherenceComponentName => "PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214";

		public override uint FieldMask => 0b00000000000000000000000000000010;

		public override bool Value
		{
			get => (bool)(CastedUnityComponent.GetBool(CastedDescriptor.ParameterHash));
			set => CastedUnityComponent.SetBool(CastedDescriptor.ParameterHash, (value));
		}

		protected override bool ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214)coherenceComponent;
			return update.GoingLeft;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214)coherenceComponent;
			update.GoingLeft = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214();
		}
	}

	public class Binding_6e41740ccd468754ebce2e5459d93cdd_03b8f679_6107_4276_9d2e_e80883db1d97 : BoolAnimatorParameterBinding
	{
		private UnityEngine.Animator CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Animator)UnityComponent;
		}
		public override string CoherenceComponentName => "PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214";

		public override uint FieldMask => 0b00000000000000000000000000000100;

		public override bool Value
		{
			get => (bool)(CastedUnityComponent.GetBool(CastedDescriptor.ParameterHash));
			set => CastedUnityComponent.SetBool(CastedDescriptor.ParameterHash, (value));
		}

		protected override bool ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214)coherenceComponent;
			return update.GoingRight;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214)coherenceComponent;
			update.GoingRight = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214();
		}
	}

	public class Binding_6e41740ccd468754ebce2e5459d93cdd_42f1511a_b47b_4946_8490_f591e3844cf3 : BoolAnimatorParameterBinding
	{
		private UnityEngine.Animator CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Animator)UnityComponent;
		}
		public override string CoherenceComponentName => "PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214";

		public override uint FieldMask => 0b00000000000000000000000000001000;

		public override bool Value
		{
			get => (bool)(CastedUnityComponent.GetBool(CastedDescriptor.ParameterHash));
			set => CastedUnityComponent.SetBool(CastedDescriptor.ParameterHash, (value));
		}

		protected override bool ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214)coherenceComponent;
			return update.GoingBack;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214)coherenceComponent;
			update.GoingBack = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214();
		}
	}


	[Preserve]
	[AddComponentMenu("coherence/Baked/Baked 'PlayerTree' (auto assigned)")]
	[RequireComponent(typeof(CoherenceSync))]
	public class CoherenceSyncPlayerTree_id1 : CoherenceSyncBaked
	{
		private CoherenceSync coherenceSync;
		private Logger logger;

		// Cached targets for commands
		private InputBuffer<PlayerTree> inputBuffer;
		private PlayerTree currentInput;
		private long lastAddedFrame = -1;
		private CoherenceInput coherenceInput;
		private long currentSimulationFrame => coherenceInput.CurrentSimulationFrame;

		private IClient client;
		private CoherenceMonoBridge monoBridge => coherenceSync.MonoBridge;

		protected void Awake()
		{
			coherenceSync = GetComponent<CoherenceSync>();
			coherenceSync.usingReflection = false;

			logger = coherenceSync.logger.With<CoherenceSyncPlayerTree_id1>();
			coherenceInput = coherenceSync.Input;
			inputBuffer = new InputBuffer<PlayerTree>(coherenceInput.InitialBufferSize, coherenceInput.InitialBufferDelay, coherenceInput.UseFixedSimulationFrames);
			if (coherenceSync.TryGetBindingByGuid("03988d14-e364-4e85-80f3-85a566ae74c5", "IsMoving", out Binding InternalPlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_IsMoving))
			{
				var clone = new Binding_6e41740ccd468754ebce2e5459d93cdd_03988d14_e364_4e85_80f3_85a566ae74c5();
				InternalPlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_IsMoving.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_IsMoving)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Animator).IsMoving");
			}
			if (coherenceSync.TryGetBindingByGuid("5a5d4943-7ac3-4a7a-8194-f6794894294c", "GoingLeft", out Binding InternalPlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_GoingLeft))
			{
				var clone = new Binding_6e41740ccd468754ebce2e5459d93cdd_5a5d4943_7ac3_4a7a_8194_f6794894294c();
				InternalPlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_GoingLeft.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_GoingLeft)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Animator).GoingLeft");
			}
			if (coherenceSync.TryGetBindingByGuid("03b8f679-6107-4276-9d2e-e80883db1d97", "GoingRight", out Binding InternalPlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_GoingRight))
			{
				var clone = new Binding_6e41740ccd468754ebce2e5459d93cdd_03b8f679_6107_4276_9d2e_e80883db1d97();
				InternalPlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_GoingRight.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_GoingRight)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Animator).GoingRight");
			}
			if (coherenceSync.TryGetBindingByGuid("42f1511a-b47b-4946-8490-f591e3844cf3", "GoingBack", out Binding InternalPlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_GoingBack))
			{
				var clone = new Binding_6e41740ccd468754ebce2e5459d93cdd_42f1511a_b47b_4946_8490_f591e3844cf3();
				InternalPlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_GoingBack.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_PlayerTree_id1_UnityEngine__char_46_Animator_5624696503662188214_GoingBack)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Animator).GoingBack");
			}
		}

		public override List<ICoherenceComponentData> CreateEntity()
		{
			if (coherenceSync.UsesLODsAtRuntime && (Archetypes.IndexForName.TryGetValue(coherenceSync.Archetype.ArchetypeName, out int archetypeIndex)))
			{
				var components = new List<ICoherenceComponentData>()
				{
					new ArchetypeComponent
					{
						index = archetypeIndex
					}
				};

				return components;
			}
			else
			{
				logger.Warning($"Unable to find archetype {coherenceSync.Archetype.ArchetypeName} in dictionary. Please, bake manually (coherence > Bake)");
			}

			return null;
		}
		private void OnDestroy()
		{
			if (monoBridge != null)
			{
				monoBridge.OnLateFixedNetworkUpdate -= SendInputState;
			}
		}

		public override void Initialize(CoherenceSync sync, IClient client)
		{
			if (coherenceSync == null)
			{
				coherenceSync = sync;
			}
			this.client = client;
			sync.Input.internalSetButtonState = SetButtonState;
			sync.Input.internalSetButtonRangeState = SetButtonRangeState;
			sync.Input.internalSetAxisState = SetAxisState;
			sync.Input.internalSetStringState = SetStringState;
			sync.Input.internalGetButtonState = GetButtonState;
			sync.Input.internalGetButtonRangeState = GetButtonRangeState;
			sync.Input.internalGetAxisState = GetAxisState;
			sync.Input.internalGetStringState = GetStringState;
			sync.Input.internalRequestBuffer = () => inputBuffer;
			sync.Input.internalOnInputReceived += OnInput;
			sync.Input.internalRequestBuffer = () => inputBuffer;

			if (coherenceInput.UseFixedSimulationFrames)
			{
				sync.MonoBridge.OnLateFixedNetworkUpdate += SendInputState;
			}
		}

		public override void ReceiveCommand(IEntityCommand command)
		{
			switch(command)
			{
				default:
					logger.Warning($"[CoherenceSyncPlayerTree_id1] Unhandled command: {command.GetType()}.");
					break;
			}
		}

		private void SetButtonState(string name, bool value)
		{
			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}
		}

		private void SetButtonRangeState(string name, float value)
		{
			switch(name)
			{
			default:
				logger.Error($"No input button range of name: {name}");
				break;
			}
		}

		private void SetAxisState(string name, Vector2 value)
		{
			switch(name)
			{
			default:
				logger.Error($"No input axis of name: {name}");
				break;
			}
		}

		private void SetStringState(string name, string value)
		{
			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}
		}

		public override void SendInputState()
		{
			if (!coherenceInput.IsProducer || !coherenceInput.IsReadyToProcessInputs || !coherenceInput.IsInputOwner)
			{
				return;
			}

			if (lastAddedFrame != currentSimulationFrame)
			{
				inputBuffer.AddInput(currentInput, currentSimulationFrame);
				lastAddedFrame = currentSimulationFrame;
			}

			while (inputBuffer.DequeueForSending(currentSimulationFrame, out long frameToSend, out PlayerTree input, out bool differs))
			{
				coherenceInput.DebugOnInputSent(frameToSend, input);
				client.SendInput(input, frameToSend, coherenceSync.EntityID);
			}
		}

		private bool ShouldPollCurrentInput(long frame)
		{
			return coherenceInput.IsProducer && coherenceInput.Delay == 0 && frame == currentSimulationFrame;
		}

		private bool GetButtonState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}

			return false;
		}

		private float GetButtonRangeState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
			default:
				logger.Error($"No input button range of name: {name}");
				break;
			}

			return 0f;
		}

		private Vector2 GetAxisState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
			default:
				logger.Error($"No input axis of name: {name}");
				break;
			}

			return Vector2.zero;
		}

		private string GetStringState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}

			return null;
		}

		private void OnInput(IEntityInput entityInput, long frame)
		{
			var input = (PlayerTree)entityInput;
			coherenceInput.DebugOnInputReceived(frame, entityInput);
			inputBuffer.ReceiveInput(input, frame);
		}
	}
}