﻿using System.Collections.Generic;

namespace x2tap.Objects.v2rayConfig
{
	/// <summary>
	///		路由
	/// </summary>
	public class Routing
	{
		public string strategy = "rules";

		/// <summary>
		///		路由设置
		/// </summary>
		public RoutingSettings settings = new RoutingSettings();
	}

	/// <summary>
	///		路由设置
	/// </summary>
	public class RoutingSettings
	{
		/// <summary>
		///		域名解析策略
		/// </summary>
		public string domainStrategy = "IPIfNonMatch";

		/// <summary>
		///		规则列表
		/// </summary>
		public List<RoutingRule> rules = new List<RoutingRule>()
		{
			new RoutingRule()
			{
				ip = new List<string>()
				{
					"1.1.1.1",
					"8.8.8.8"
				},
				outboundTag = "defaultOutbound"
			},
			new RoutingRule()
			{
				ip = new List<string>()
				{
					"1.2.4.8",
					"114.114.114.114"
				},
				outboundTag = "directOutbound"
			},
			new RoutingRule()
			{
				inboundTag = new List<string>()
				{
					"dnsInbound"
				},
				outboundTag = "dnsOutbound"
			},
		};
	}

	/// <summary>
	///		路由规则
	/// </summary>
	public class RoutingRule
	{
		/// <summary>
		///		类型
		/// </summary>
		public string type = "field";

		/// <summary>
		///		域名
		/// </summary>
		public List<string> domain;

		/// <summary>
		///		IP
		/// </summary>
		public List<string> ip;

		/// <summary>
		///		入口标签
		/// </summary>
		public List<string> inboundTag;

		/// <summary>
		///		出口标签
		/// </summary>
		public string outboundTag;
	}
}
