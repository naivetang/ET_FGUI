﻿using ETModel;

namespace ETHotfix
{
    public partial class BulletCfg
    {
        public string Name()
        {
            if (GameSettingsViewComponent.GetLanguage() == Language.Chinese)
            {
                return this.Chinese;
            }
            else
            {
                return this.English;
            }
        }

        public string Type()
        {
            if (GameSettingsViewComponent.GetLanguage() == Language.Chinese)
            {
                return "炮弹";
            }
            else
            {
                return "Bullet";
            }
        }
    }
}
