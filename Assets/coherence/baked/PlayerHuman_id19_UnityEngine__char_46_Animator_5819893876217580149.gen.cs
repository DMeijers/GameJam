// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using Coherence.ProtocolDef;
	using Coherence.Serializer;
	using Coherence.SimulationFrame;
	using Coherence.Entity;
	using Coherence.Utils;
	using Coherence.Brook;
	using Coherence.Toolkit;
	using UnityEngine;

	public struct PlayerHuman_id19_UnityEngine__char_46_Animator_5819893876217580149 : ICoherenceComponentData
	{
		public bool IsMoving;
		public bool GoingLeft;
		public bool GoingRight;
		public bool GoingBack;

		public override string ToString()
		{
			return $"PlayerHuman_id19_UnityEngine__char_46_Animator_5819893876217580149(IsMoving: {IsMoving}, GoingLeft: {GoingLeft}, GoingRight: {GoingRight}, GoingBack: {GoingBack})";
		}

		public uint GetComponentType() => Definition.InternalPlayerHuman_id19_UnityEngine__char_46_Animator_5819893876217580149;

		public const int order = 0;

		public int GetComponentOrder() => order;

		public AbsoluteSimulationFrame Frame;
	

		public void SetSimulationFrame(AbsoluteSimulationFrame frame)
		{
			Frame = frame;
		}

		public AbsoluteSimulationFrame GetSimulationFrame() => Frame;

		public ICoherenceComponentData MergeWith(ICoherenceComponentData data, uint mask)
		{
			var other = (PlayerHuman_id19_UnityEngine__char_46_Animator_5819893876217580149)data;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				IsMoving = other.IsMoving;
			}
			mask >>= 1;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				GoingLeft = other.GoingLeft;
			}
			mask >>= 1;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				GoingRight = other.GoingRight;
			}
			mask >>= 1;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				GoingBack = other.GoingBack;
			}
			mask >>= 1;
			return this;
		}

		public static void Serialize(PlayerHuman_id19_UnityEngine__char_46_Animator_5819893876217580149 data, uint mask, IOutProtocolBitStream bitStream)
		{
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteBool(data.IsMoving);
			}
			mask >>= 1;
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteBool(data.GoingLeft);
			}
			mask >>= 1;
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteBool(data.GoingRight);
			}
			mask >>= 1;
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteBool(data.GoingBack);
			}
			mask >>= 1;
		}

		public static (PlayerHuman_id19_UnityEngine__char_46_Animator_5819893876217580149, uint, uint?) Deserialize(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new PlayerHuman_id19_UnityEngine__char_46_Animator_5819893876217580149();
	
			if (bitStream.ReadMask())
			{
				val.IsMoving = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000001;
			}
			if (bitStream.ReadMask())
			{
				val.GoingLeft = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000010;
			}
			if (bitStream.ReadMask())
			{
				val.GoingRight = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000100;
			}
			if (bitStream.ReadMask())
			{
				val.GoingBack = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000001000;
			}
			return (val, mask, null);
		}
		public static (PlayerHuman_id19_UnityEngine__char_46_Animator_5819893876217580149, uint, uint?) DeserializeArchetypePlayerHuman_6d57491473fb68a4a87f6eca2180c0d4_PlayerHuman_id19_UnityEngine__char_46_Animator_5819893876217580149_LOD0(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new PlayerHuman_id19_UnityEngine__char_46_Animator_5819893876217580149();
			if (bitStream.ReadMask())
			{
				val.IsMoving = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000001;
			}
			if (bitStream.ReadMask())
			{
				val.GoingLeft = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000010;
			}
			if (bitStream.ReadMask())
			{
				val.GoingRight = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000100;
			}
			if (bitStream.ReadMask())
			{
				val.GoingBack = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000001000;
			}

			return (val, mask, 0);
		}

		/// <summary>
		/// Resets byte array references to the local array instance that is kept in the lastSentData.
		/// If the array content has changed but remains of same length, the new content is copied into the local array instance.
		/// If the array length has changed, the array is cloned and overwrites the local instance.
		/// If the array has not changed, the reference is reset to the local array instance.
		/// Otherwise, changes to other fields on the component might cause the local array instance reference to become permanently lost.
		/// </summary>
		public void ResetByteArrays(ICoherenceComponentData lastSent, uint mask)
		{
			var last = lastSent as PlayerHuman_id19_UnityEngine__char_46_Animator_5819893876217580149?;
	
		}
	}
}