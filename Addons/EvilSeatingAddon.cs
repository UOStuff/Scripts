
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class EvilSeatingAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4681, -1, 0, 1}, {4704, -2, 3, 0}, {4731, 1, -3, 0}// 1	2	3	
			, {4732, 0, -3, 0}, {4730, 2, -3, 0}, {4729, 2, -2, 0}// 4	5	6	
			, {4728, 1, -2, 0}, {4727, 0, -2, 0}, {4726, 0, -1, 0}// 7	8	9	
			, {4725, 1, -1, 0}, {4724, 2, -1, 0}, {2860, 2, 2, 0}// 10	11	12	
			, {2860, 2, 1, 0}, {2861, 0, 3, 0}, {2861, 1, 3, 0}// 13	14	15	
			, {4655, -1, 2, 2}, {7440, 0, 0, 1}, {3792, -1, 2, 1}// 16	17	18	
			, {4071, -1, 0, 0}, {4072, 0, 0, 0}, {4075, 1, 0, 0}// 19	20	21	
			, {4070, -1, 1, 0}, {4074, 0, 1, 0}, {4078, 1, 1, 0}// 22	23	24	
			, {4073, -1, 2, 0}, {4076, 0, 2, 0}, {4077, 1, 2, 0}// 25	26	27	
			, {4309, 0, -1, 0}, {4308, -2, 1, 1}// 28	29	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new EvilSeatingAddonDeed();
			}
		}

		[ Constructable ]
		public EvilSeatingAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public EvilSeatingAddon( Serial serial ) : base( serial )
		{
		}


		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class EvilSeatingAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new EvilSeatingAddon();
			}
		}

		[Constructable]
		public EvilSeatingAddonDeed()
		{
			Name = "EvilSeating";
		}

		public EvilSeatingAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}