﻿



// *** DO NOT EDIT THIS FILE, IT HAS BEEN AUTO-GENERATED ***

using System;
using System.Runtime.InteropServices;
using u8 = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;
using i8 = System.SByte;
using i16 = System.Int16;
using i32 = System.Int32;
using i64 = System.Int64;
using f32 = System.Single;
using f64 = System.Double;
using str = System.String;

using ConnectionId = System.UInt64;
using ClientUidT = System.String;
using ClientDbIdT = System.UInt64;
using ClientId = System.UInt16;
using ChannelIdT = System.UInt64;
using ServerGroupIdT = System.UInt64;
using ChannelGroupIdT = System.UInt64;
using TimeSpanSecondsT = System.TimeSpan;
using TimeSpanMillisecT = System.TimeSpan;

#pragma warning disable IDE1006

namespace WrapperCore.Dto
{
	public sealed class Connection
	{
		public Connection(ConnectionId ConnectionId)
		{
			this.ConnectionId = this.ConnectionId;
		}
		public ConnectionId ConnectionId { get; }

	}

	public sealed class ClientNetwork
	{
		[DllImport("tslib")] private static extern f32 get_client_network_ping();
		[DllImport("tslib")] private static extern f32 set_client_network_ping(f32 Ping);
		public f32 Ping { get => get_client_network_ping(); set => set_client_network_ping(value); }
	}

	///<summary>lalala</summary>
	public sealed class Client
	{
		public Client(ConnectionId ConnectionId, ClientId ClientId)
		{
			this.ConnectionId = this.ConnectionId;
			this.ClientId = this.ClientId;
		}
		public ConnectionId ConnectionId { get; }
		///<summary>Id to iderntify a connected user</summary>
		public ClientId ClientId { get; }

		[DllImport("tslib")] private static extern str get_client_welcome_message();
		[DllImport("tslib")] private static extern str set_client_welcome_message(str WelcomeMessage);
		///<summary>Welcome message when conecting to a server.</summary>
		public str WelcomeMessage { get => get_client_welcome_message(); set => set_client_welcome_message(value); }
		[DllImport("tslib")] private static extern u32 get_client_max_clients();
		[DllImport("tslib")] private static extern u32 set_client_max_clients(u32 MaxClients);
		public u32 MaxClients { get => get_client_max_clients(); set => set_client_max_clients(value); }
		[DllImport("tslib")] private static extern u32 get_client_clients_online();
		[DllImport("tslib")] private static extern u32 set_client_clients_online(u32 ClientsOnline);
		public u32 ClientsOnline { get => get_client_clients_online(); set => set_client_clients_online(value); }
		[DllImport("tslib")] private static extern u32 get_client_channels_online();
		[DllImport("tslib")] private static extern u32 set_client_channels_online(u32 ChannelsOnline);
		public u32 ChannelsOnline { get => get_client_channels_online(); set => set_client_channels_online(value); }
		[DllImport("tslib")] private static extern u32 get_client_client_connections();
		[DllImport("tslib")] private static extern u32 set_client_client_connections(u32 ClientConnections);
		public u32 ClientConnections { get => get_client_client_connections(); set => set_client_client_connections(value); }
		[DllImport("tslib")] private static extern u32 get_client_query_client_connections();
		[DllImport("tslib")] private static extern u32 set_client_query_client_connections(u32 QueryClientConnections);
		public u32 QueryClientConnections { get => get_client_query_client_connections(); set => set_client_query_client_connections(value); }
		[DllImport("tslib")] private static extern u32 get_client_query_clients_online();
		[DllImport("tslib")] private static extern u32 set_client_query_clients_online(u32 QueryClientsOnline);
		public u32 QueryClientsOnline { get => get_client_query_clients_online(); set => set_client_query_clients_online(value); }
		[DllImport("tslib")] private static extern TimeSpan get_client_uptime();
		[DllImport("tslib")] private static extern TimeSpan set_client_uptime(TimeSpan Uptime);
		public TimeSpan Uptime { get => get_client_uptime(); set => set_client_uptime(value); }
		[DllImport("tslib")] private static extern bool get_client_password();
		[DllImport("tslib")] private static extern bool set_client_password(bool Password);
		public bool Password { get => get_client_password(); set => set_client_password(value); }
		[DllImport("tslib")] private static extern u32 get_client_max_download_total_bandwith();
		[DllImport("tslib")] private static extern u32 set_client_max_download_total_bandwith(u32 MaxDownloadTotalBandwith);
		public u32 MaxDownloadTotalBandwith { get => get_client_max_download_total_bandwith(); set => set_client_max_download_total_bandwith(value); }
		[DllImport("tslib")] private static extern u32 get_client_max_upload_total_bandwith();
		[DllImport("tslib")] private static extern u32 set_client_max_upload_total_bandwith(u32 MaxUploadTotalBandwith);
		public u32 MaxUploadTotalBandwith { get => get_client_max_upload_total_bandwith(); set => set_client_max_upload_total_bandwith(value); }
		[DllImport("tslib")] private static extern u32 get_client_download_quota();
		[DllImport("tslib")] private static extern u32 set_client_download_quota(u32 DownloadQuota);
		public u32 DownloadQuota { get => get_client_download_quota(); set => set_client_download_quota(value); }
		[DllImport("tslib")] private static extern u32 get_client_upload_quota();
		[DllImport("tslib")] private static extern u32 set_client_upload_quota(u32 UploadQuota);
		public u32 UploadQuota { get => get_client_upload_quota(); set => set_client_upload_quota(value); }
		[DllImport("tslib")] private static extern u32 get_client_month_bytes_downloaded();
		[DllImport("tslib")] private static extern u32 set_client_month_bytes_downloaded(u32 MonthBytesDownloaded);
		public u32 MonthBytesDownloaded { get => get_client_month_bytes_downloaded(); set => set_client_month_bytes_downloaded(value); }
		[DllImport("tslib")] private static extern u32 get_client_month_bytes_uploaded();
		[DllImport("tslib")] private static extern u32 set_client_month_bytes_uploaded(u32 MonthBytesUploaded);
		public u32 MonthBytesUploaded { get => get_client_month_bytes_uploaded(); set => set_client_month_bytes_uploaded(value); }
		[DllImport("tslib")] private static extern u32 get_client_total_bytes_downloaded();
		[DllImport("tslib")] private static extern u32 set_client_total_bytes_downloaded(u32 TotalBytesDownloaded);
		public u32 TotalBytesDownloaded { get => get_client_total_bytes_downloaded(); set => set_client_total_bytes_downloaded(value); }
		[DllImport("tslib")] private static extern u32 get_client_total_bytes_uploaded();
		[DllImport("tslib")] private static extern u32 set_client_total_bytes_uploaded(u32 TotalBytesUploaded);
		public u32 TotalBytesUploaded { get => get_client_total_bytes_uploaded(); set => set_client_total_bytes_uploaded(value); }
		[DllImport("tslib")] private static extern u32 get_client_complain_autoban_count();
		[DllImport("tslib")] private static extern u32 set_client_complain_autoban_count(u32 ComplainAutobanCount);
		public u32 ComplainAutobanCount { get => get_client_complain_autoban_count(); set => set_client_complain_autoban_count(value); }
		[DllImport("tslib")] private static extern TimeSpan get_client_complain_autoban_time();
		[DllImport("tslib")] private static extern TimeSpan set_client_complain_autoban_time(TimeSpan ComplainAutobanTime);
		public TimeSpan ComplainAutobanTime { get => get_client_complain_autoban_time(); set => set_client_complain_autoban_time(value); }
		[DllImport("tslib")] private static extern TimeSpan get_client_complain_remove_time();
		[DllImport("tslib")] private static extern TimeSpan set_client_complain_remove_time(TimeSpan ComplainRemoveTime);
		public TimeSpan ComplainRemoveTime { get => get_client_complain_remove_time(); set => set_client_complain_remove_time(value); }
		[DllImport("tslib")] private static extern u32 get_client_min_clients_in_channel_before_forced_silence();
		[DllImport("tslib")] private static extern u32 set_client_min_clients_in_channel_before_forced_silence(u32 MinClientsInChannelBeforeForcedSilence);
		public u32 MinClientsInChannelBeforeForcedSilence { get => get_client_min_clients_in_channel_before_forced_silence(); set => set_client_min_clients_in_channel_before_forced_silence(value); }
		[DllImport("tslib")] private static extern u32 get_client_antiflood_points_tick_reduce();
		[DllImport("tslib")] private static extern u32 set_client_antiflood_points_tick_reduce(u32 AntifloodPointsTickReduce);
		public u32 AntifloodPointsTickReduce { get => get_client_antiflood_points_tick_reduce(); set => set_client_antiflood_points_tick_reduce(value); }
		[DllImport("tslib")] private static extern u32 get_client_antiflood_points_needed_command_block();
		[DllImport("tslib")] private static extern u32 set_client_antiflood_points_needed_command_block(u32 AntifloodPointsNeededCommandBlock);
		public u32 AntifloodPointsNeededCommandBlock { get => get_client_antiflood_points_needed_command_block(); set => set_client_antiflood_points_needed_command_block(value); }
		[DllImport("tslib")] private static extern u32 get_client_antiflood_points_needed_ip_block();
		[DllImport("tslib")] private static extern u32 set_client_antiflood_points_needed_ip_block(u32 AntifloodPointsNeededIpBlock);
		public u32 AntifloodPointsNeededIpBlock { get => get_client_antiflood_points_needed_ip_block(); set => set_client_antiflood_points_needed_ip_block(value); }
		[DllImport("tslib")] private static extern u16 get_client_port();
		[DllImport("tslib")] private static extern u16 set_client_port(u16 Port);
		public u16 Port { get => get_client_port(); set => set_client_port(value); }
		[DllImport("tslib")] private static extern bool get_client_autostart();
		[DllImport("tslib")] private static extern bool set_client_autostart(bool Autostart);
		public bool Autostart { get => get_client_autostart(); set => set_client_autostart(value); }
		[DllImport("tslib")] private static extern u32 get_client_machine_id();
		[DllImport("tslib")] private static extern u32 set_client_machine_id(u32 MachineId);
		public u32 MachineId { get => get_client_machine_id(); set => set_client_machine_id(value); }
		[DllImport("tslib")] private static extern u32 get_client_needed_identity_security_level();
		[DllImport("tslib")] private static extern u32 set_client_needed_identity_security_level(u32 NeededIdentitySecurityLevel);
		public u32 NeededIdentitySecurityLevel { get => get_client_needed_identity_security_level(); set => set_client_needed_identity_security_level(value); }
		[DllImport("tslib")] private static extern bool get_client_log_client();
		[DllImport("tslib")] private static extern bool set_client_log_client(bool LogClient);
		public bool LogClient { get => get_client_log_client(); set => set_client_log_client(value); }
		[DllImport("tslib")] private static extern bool get_client_log_query();
		[DllImport("tslib")] private static extern bool set_client_log_query(bool LogQuery);
		public bool LogQuery { get => get_client_log_query(); set => set_client_log_query(value); }
		[DllImport("tslib")] private static extern bool get_client_log_channel();
		[DllImport("tslib")] private static extern bool set_client_log_channel(bool LogChannel);
		public bool LogChannel { get => get_client_log_channel(); set => set_client_log_channel(value); }
		[DllImport("tslib")] private static extern bool get_client_log_permissions();
		[DllImport("tslib")] private static extern bool set_client_log_permissions(bool LogPermissions);
		public bool LogPermissions { get => get_client_log_permissions(); set => set_client_log_permissions(value); }
		[DllImport("tslib")] private static extern bool get_client_log_server();
		[DllImport("tslib")] private static extern bool set_client_log_server(bool LogServer);
		public bool LogServer { get => get_client_log_server(); set => set_client_log_server(value); }
		[DllImport("tslib")] private static extern bool get_client_log_filetransfer();
		[DllImport("tslib")] private static extern bool set_client_log_filetransfer(bool LogFiletransfer);
		public bool LogFiletransfer { get => get_client_log_filetransfer(); set => set_client_log_filetransfer(value); }
		[DllImport("tslib")] private static extern str get_client_min_client_version();
		[DllImport("tslib")] private static extern str set_client_min_client_version(str MinClientVersion);
		public str MinClientVersion { get => get_client_min_client_version(); set => set_client_min_client_version(value); }
		[DllImport("tslib")] private static extern u32 get_client_total_packetloss_speech();
		[DllImport("tslib")] private static extern u32 set_client_total_packetloss_speech(u32 TotalPacketlossSpeech);
		public u32 TotalPacketlossSpeech { get => get_client_total_packetloss_speech(); set => set_client_total_packetloss_speech(value); }
		[DllImport("tslib")] private static extern u32 get_client_total_packetloss_keepalive();
		[DllImport("tslib")] private static extern u32 set_client_total_packetloss_keepalive(u32 TotalPacketlossKeepalive);
		public u32 TotalPacketlossKeepalive { get => get_client_total_packetloss_keepalive(); set => set_client_total_packetloss_keepalive(value); }
		[DllImport("tslib")] private static extern u32 get_client_total_packetloss_control();
		[DllImport("tslib")] private static extern u32 set_client_total_packetloss_control(u32 TotalPacketlossControl);
		public u32 TotalPacketlossControl { get => get_client_total_packetloss_control(); set => set_client_total_packetloss_control(value); }
		[DllImport("tslib")] private static extern u32 get_client_total_packetloss_total();
		[DllImport("tslib")] private static extern u32 set_client_total_packetloss_total(u32 TotalPacketlossTotal);
		public u32 TotalPacketlossTotal { get => get_client_total_packetloss_total(); set => set_client_total_packetloss_total(value); }
		[DllImport("tslib")] private static extern u32 get_client_total_ping();
		[DllImport("tslib")] private static extern u32 set_client_total_ping(u32 TotalPing);
		public u32 TotalPing { get => get_client_total_ping(); set => set_client_total_ping(value); }
		[DllImport("tslib")] private static extern bool get_client_weblist_enabled();
		[DllImport("tslib")] private static extern bool set_client_weblist_enabled(bool WeblistEnabled);
		public bool WeblistEnabled { get => get_client_weblist_enabled(); set => set_client_weblist_enabled(value); }
	}

	public sealed class Unknown1
	{
		[DllImport("tslib")] private static extern str get_unknown1_hostmessage();
		[DllImport("tslib")] private static extern str set_unknown1_hostmessage(str hostmessage);
		public str hostmessage { get => get_unknown1_hostmessage(); set => set_unknown1_hostmessage(value); }
		[DllImport("tslib")] private static extern HostMessageMode get_unknown1_hostmessage_mode();
		[DllImport("tslib")] private static extern HostMessageMode set_unknown1_hostmessage_mode(HostMessageMode hostmessage_mode);
		public HostMessageMode hostmessage_mode { get => get_unknown1_hostmessage_mode(); set => set_unknown1_hostmessage_mode(value); }
	}

}

#pragma warning restore IDE1006
