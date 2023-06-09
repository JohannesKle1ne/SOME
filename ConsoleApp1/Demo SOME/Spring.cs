﻿using Shard;
using System;
using System.Drawing;
using System.Xml.Linq;

namespace JumpAndRun
{
    class Spring : Reward
    {

        public Spring(bool synced)
        {
            syncedInitialize();
            this.synced = true;

        }
        public Spring()
        {
            localInitialize();
            this.synced = false;
        }
        public override void localInitialize()
        {
            base.localInitialize();
            addTag("Spring");
            setSpriteName("spring");
        }

        public override void syncedInitialize()
        {
            base.syncedInitialize();
            addTag("Spring");
            setSpriteName("spring");
        }
    }
}
