﻿using System.Collections.Generic;

using Terraria.Enums;

using static GluttonySandbox.Content.Items.Weapons.Melee.Yoyos.TooltipHelper;
using static GluttonySandbox.PathFinder;

namespace GluttonySandbox.Content.Items.Weapons.Melee.Yoyos
{
    public class Abduction : ModItem
    {
        public override string Texture => GetTexturePath(nameof(Item), nameof(Abduction));

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.WoodYoyo);
            Item.SetWeaponValues(15, 4f);
            Item.SetShopValues(ItemRarityColor.Blue1, Item.sellPrice(silver: 75));

            Item.shoot = ModContent.ProjectileType<Projectiles.Melee.Yoyos.Abduction>();
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips) => InsertEmptyTooltip(Mod, tooltips);

        public override void PostDrawTooltipLine(DrawableTooltipLine line) => DrawUnprldLogo(line);
    }
}
