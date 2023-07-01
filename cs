port: 7890
socks-port: 7891
allow-lan: true
mode: rule
log-level: info
# external-controller: 2254
ipv6: true
geox-url:
  geoip: "https://cdn.jsdelivr.net/gh/Loyalsoldier/v2ray-rules-dat@release/geoip.dat"
  geosite: "https://cdn.jsdelivr.net/gh/Loyalsoldier/v2ray-rules-dat@release/geosite.dat"
  mmdb: "https://cdn.jsdelivr.net/gh/Loyalsoldier/geoip@release/Country.mmdb"
dns:
  enable: true
  prefer-h3: true
  listen: 0.0.0.0:53
  ipv6: true
  nameserver:
    - tcp://20.239.89.216:55521
proxies:
  - {name: v.ps年付日本, server: 223.5.5.5, port: 443, reality-opts: {public-key: 25d83612-9be4-480b-b82b-50ed9d590c02, short-id: aaaaaaaaaaaaaaaa}, client-fingerprint: chrome, type: vless, uuid: 25d83612-9be4-480b-b82b-50ed9d590c02, tls: true, tfo: false, servername: google.com, flow: xtls-rprx-vision, skip-cert-verify: false, udp: true}
