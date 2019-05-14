namespace BasicLibrary
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Serialization;

    /// <summary>
    ///     JSON 序列化
    /// </summary>
    public static class JSON
    {
        #region Public Methods and Operators

        /// <summary>
        /// 将 json 格式的串转化为相应的实体
        /// </summary>
        /// <typeparam name="T">
        /// T
        /// </typeparam>
        /// <param name="jsonData">
        /// json串
        /// </param>
        /// <returns>
        /// T
        /// </returns>
        public static T Deserialize<T>(string jsonData)
        {
            return JsonConvert.DeserializeObject<T>(jsonData, SerializerSetting());
        }

        /// <summary>
        /// 反序列化JSON到给定的匿名对象.
        /// </summary>
        /// <typeparam name="T">
        /// 匿名对象类型
        /// </typeparam>
        /// <param name="json">
        /// json字符串
        /// </param>
        /// <param name="anonymousTypeObject">
        /// 匿名对象
        /// </param>
        /// <returns>
        /// T
        /// </returns>
        public static T DeserializeAnonymousType<T>(string json, T anonymousTypeObject)
        {
            T t = JsonConvert.DeserializeAnonymousType(json, anonymousTypeObject, SerializerSetting());
            return t;
        }

        /// <summary>
        /// 将实体转化为 json 格式的字符串
        /// </summary>
        /// <param name="data">
        /// entity
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string Serialize(object data)
        {
            return JsonConvert.SerializeObject(data, Formatting.Indented, SerializerSetting());
        }

        #endregion

        #region Methods

        /// <summary>
        ///     json 序列化设置
        /// </summary>
        /// <returns>
        ///     The <see cref="JsonSerializerSettings" />.
        /// </returns>
        private static JsonSerializerSettings SerializerSetting()
        {
            var setting = new JsonSerializerSettings();
            setting.ReferenceLoopHandling = ReferenceLoopHandling.Serialize;
            setting.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat;
            setting.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
            setting.NullValueHandling = NullValueHandling.Ignore;
            setting.MissingMemberHandling = MissingMemberHandling.Ignore;
            setting.ContractResolver = new DefaultContractResolver
            {
                IgnoreSerializableInterface = true,
                IgnoreSerializableAttribute = true
            };
            setting.Error = delegate (object obj, ErrorEventArgs args)
            {
                args.ErrorContext.Handled = true;
            };

            return setting;
        }


        /// <summary>
        /// 使用JSON.NET 转换JSON字符串到.NET对象
        /// </summary>
        /// <param name="strJson"></param>
        /// <returns></returns>
        public static T Convert<T, O>(O strJson)
        {
            if (strJson != null)
            {
                return ConvertToObject<T>(ConvertToJosnString(strJson));
            }
            return default(T);
        }

        /// <summary>
        /// 使用JSON.NET 转换对象到JSON字符串
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string ConvertToJosnString1(object item)
        {
            if (item != null)
            {
                IsoDateTimeConverter mTimeConverter = new IsoDateTimeConverter();
                mTimeConverter.DateTimeFormat = "yyyy/MM/dd HH:mm:ss";
                return JsonConvert.SerializeObject(item, Formatting.Indented, mTimeConverter);
            }
            return "";
        }
        public static string ConvertToJosnString(object item)
        {
            if (item != null)
            {
                return JsonConvert.SerializeObject(item).Replace("\"{", "{").Replace("}\"", "}").Replace("\\", "");
            }
            return "";
        }

        /// <summary>
        /// 使用JSON.NET 转换JSON字符串到.NET对象
        /// </summary>
        /// <param name="strJson"></param>
        /// <returns></returns>
        public static T ConvertToObject<T>(string strJson)
        {
            if (!string.IsNullOrEmpty(strJson))
            {
                return JsonConvert.DeserializeObject<T>(strJson);
            }
            return default(T);
        }


        #endregion
    }
}
