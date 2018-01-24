using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CN.Jpush.Android.Service
{
    /// <summary>
    /// <!-- Required SDK核心功能-->
    ///<service android:name="cn.jpush.android.service.DownloadService" android:enabled="true" android:exported="false"></service>
    /// </summary>
    [Service(Name = "cn.jpush.android.service.DownloadService", Enabled = true, Exported = false)]
    public partial class DownloadService
    {

    }
    /// <!-- Required SDK 核心功能--><!-- 可配置android:process参数将PushService放在其他进程中 -->
    ///  <service android:name="cn.jpush.android.service.PushService" android:process=":mult">
    ///  <intent-filter>
    ///     <action android:name="cn.jpush.android.intent.REGISTER" />
    ///    <action android:name="cn.jpush.android.intent.REPORT" />
    ///    <action android:name="cn.jpush.android.intent.PushService" />
    ///     <action android:name="cn.jpush.android.intent.PUSH_TIME" />
    ///   </intent-filter>
    ///  </service>
    [Service(Name = "cn.jpush.android.service.PushService", Process = ":mult")]
    [IntentFilter(actions: new string[] { "cn.jpush.android.intent.REGISTER", "cn.jpush.android.intent.REPORT", "cn.jpush.android.intent.PushService", "cn.jpush.android.intent.PUSH_TIME" })]
    public partial class PushService
    {
    }
}