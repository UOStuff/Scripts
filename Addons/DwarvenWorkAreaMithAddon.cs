/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class DwarvenWorkAreaMithAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DwarvenWorkAreaMithAddonDeed();
			}
		}

		[ Constructable ]
		public DwarvenWorkAreaMithAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3263 );
			ac.Hue = 2668;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 1, -1, 2 );
			ac = new AddonComponent( 4015 );
			ac.Hue = 2256;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 7949 );
			ac.Hue = 622;
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 7950 );
			ac.Hue = 622;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 14133 );
			ac.Hue = 1150;
			AddComponent( ac, 1, -1, 2 );
			ac = new AddonComponent( 4017 );
			ac.Hue = 2256;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 3707 );
			AddComponent( ac, 1, -1, 2 );
			ac = new AddonComponent( 6585 );
			ac.Hue = 1158;
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 7154 );
			ac.Hue = 1158;
			AddComponent( ac, 3, -1, 6 );
			ac = new AddonComponent( 7154 );
			ac.Hue = 1158;
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 7154 );
			ac.Hue = 1158;
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 3380 );
			ac.Hue = 622;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 7949 );
			ac.Hue = 622;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 9036 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 9035 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 3263 );
			ac.Hue = 2668;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3263 );
			ac.Hue = 2668;
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 3262 );
			ac.Hue = 2668;
			AddComponent( ac, -1, -1, 0 );

		}

		public DwarvenWorkAreaMithAddon( Serial serial ) : base( serial )
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

	public class DwarvenWorkAreaMithAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DwarvenWorkAreaMithAddon();
			}
		}

		[Constructable]
		public DwarvenWorkAreaMithAddonDeed()
		{
			Name = "DwarvenWorkAreaMith";
		}

		public DwarvenWorkAreaMithAddonDeed( Serial serial ) : base( serial )
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