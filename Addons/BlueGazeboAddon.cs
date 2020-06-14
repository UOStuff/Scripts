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
	public class BlueGazeboAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BlueGazeboAddonDeed();
			}
		}

		[ Constructable ]
		public BlueGazeboAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3211 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 3211 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, 1, 1, 33 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 3, 1, 32 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, 0, -1, 32 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, 0, 2, 32 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, -1, 3, 31 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 3233 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 3233 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 1 );
			ac.Hue = 1405;
			AddComponent( ac, 1, 1, 31 );
			ac = new AddonComponent( 3211 );
			AddComponent( ac, 2, -3, 0 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 4, 1, 31 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 3, 4, 32 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, 4, 4, 0 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 4, -1, 31 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, -1, 0, 31 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 1, 3, 0 );
			ac = new AddonComponent( 13782 );
			ac.Hue = 1405;
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 3233 );
			AddComponent( ac, -3, -2, 0 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 4, 4, 31 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, 1, 0, 33 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 4, 3, 31 );
			ac = new AddonComponent( 3314 );
			AddComponent( ac, -1, 3, 5 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 11186 );
			ac.Hue = 1405;
			AddComponent( ac, -2, -2, 5 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, 0, 4, 32 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, 1, 4, 33 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 3, 2, 32 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, 1, 3, 33 );
			ac = new AddonComponent( 13779 );
			ac.Hue = 1405;
			AddComponent( ac, 4, 1, 0 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 4, 2, 31 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, 0, 0, 32 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 3, 3, 32 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 2, -1, 33 );
			ac = new AddonComponent( 3212 );
			AddComponent( ac, -1, 4, 0 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, -1, -1, 31 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, 1, 2, 33 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, -1, 1, 31 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 3211 );
			AddComponent( ac, 4, -1, 0 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 2, 0, 33 );
			ac = new AddonComponent( 13782 );
			ac.Hue = 1405;
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, 0, 3, 32 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 2, 1, 33 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, -1, 2, 31 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 13780 );
			ac.Hue = 1405;
			AddComponent( ac, 0, 4, 0 );
			ac = new AddonComponent( 3232 );
			AddComponent( ac, 4, 3, 0 );
			ac = new AddonComponent( 3314 );
			AddComponent( ac, 4, 3, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, 4, 3, 0 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, -1, 4, 31 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 3, -1, 32 );
			ac = new AddonComponent( 3211 );
			AddComponent( ac, 2, 4, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 3236 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 3211 );
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 3314 );
			AddComponent( ac, -2, -2, 5 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 2, 3, 33 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 4, 0, 31 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 3, 0, 32 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 2, 4, 33 );
			ac = new AddonComponent( 3236 );
			AddComponent( ac, 3, 4, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, 1, -1, 33 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 0, 3, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 11158 );
			ac.Hue = 1405;
			AddComponent( ac, 0, 1, 32 );
			ac = new AddonComponent( 3233 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 13781 );
			ac.Hue = 1405;
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 3212 );
			AddComponent( ac, 4, 2, 0 );
			ac = new AddonComponent( 3236 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 3314 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 13780 );
			ac.Hue = 1405;
			AddComponent( ac, 1, 4, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 13781 );
			ac.Hue = 1405;
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 11186 );
			ac.Hue = 1405;
			AddComponent( ac, 3, 3, 5 );
			ac = new AddonComponent( 11186 );
			ac.Hue = 1405;
			AddComponent( ac, -2, 3, 5 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, -2, 4, 0 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, -4, -4, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 11157 );
			ac.Hue = 1405;
			AddComponent( ac, 2, 2, 33 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 13778 );
			ac.Hue = 1405;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 13779 );
			ac.Hue = 1405;
			AddComponent( ac, 4, 0, 0 );
			ac = new AddonComponent( 11186 );
			ac.Hue = 1405;
			AddComponent( ac, 3, -2, 5 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, -3, 3, 0 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, -1, 3, 5 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, 4, 3, 0 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, 2, -3, 0 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, 2, -4, 0 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, -2, -4, 0 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, -4, 2, 0 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, 3, 4, 0 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, -4, -2, 0 );

		}

		public BlueGazeboAddon( Serial serial ) : base( serial )
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

	public class BlueGazeboAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BlueGazeboAddon();
			}
		}

		[Constructable]
		public BlueGazeboAddonDeed()
		{
			Name = "BlueGazebo";
		}

		public BlueGazeboAddonDeed( Serial serial ) : base( serial )
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