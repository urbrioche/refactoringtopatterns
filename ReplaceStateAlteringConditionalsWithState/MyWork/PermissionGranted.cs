﻿namespace ReplaceStateAlteringConditionalsWithState.MyWork
{
    public class PermissionGranted : PermissionState
    {
        public override void claimBy(SystemAdmin admin, SystemPermission systemPermission)
        {
        }

        public override void grantBy(SystemAdmin admin, SystemPermission systemPermission)
        {
        }

        public override void deniedBy(SystemAdmin admin, SystemPermission systemPermission)
        {
        }
    }
}