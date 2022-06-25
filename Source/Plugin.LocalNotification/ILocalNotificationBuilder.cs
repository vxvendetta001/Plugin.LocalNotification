﻿using Plugin.LocalNotification.AndroidOption;
using Plugin.LocalNotification.iOSOption;
using Plugin.LocalNotification.Json;
using System;

namespace Plugin.LocalNotification
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILocalNotificationBuilder
    {
        /// <summary>
        /// Register notification categories and their corresponding actions
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        ILocalNotificationBuilder AddCategory(NotificationCategory category);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serializer"></param>
        /// <returns></returns>
        ILocalNotificationBuilder SetSerializer(INotificationSerializer serializer);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="android"></param>
        /// <returns></returns>
        IAndroidLocalNotificationBuilder AddAndroid(Action<IAndroidLocalNotificationBuilder> android);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iOS"></param>
        /// <returns></returns>
        IiOSLocalNotificationBuilder AddiOS(Action<IiOSLocalNotificationBuilder> iOS);
    }
}
