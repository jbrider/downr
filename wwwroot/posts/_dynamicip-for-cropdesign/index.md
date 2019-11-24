---
title: Dynamic IP for CropDesign.net
slug: _dynamicip-for-cropdesign
author: bradygaster
lastModified: 2019-11-24 11:06:00
pubDate: 2019-11-24 11:06:00
categories: Personal
---

I had to setup a server from home for a short time, but found out - eventually, that my ip was not nearly as static as I thought it was.  

The other thing I learned was that when testing your public ip address - it may work fine from inside the router, but from outside the router it may have to go through any firewall settings from your isp.  

I was able to find a setting on my isp [firewall](https://secure.internode.on.net/myinternode/sys2/aclchange) settings to turn off the firewall - and will be turning it back on as soon as I don't need to have the server running rom home.


![Open DNS => DNS O Matic => Cloudflare](./media/clip.jpg "Open DNS => DNS O Matic => Cloudflare")


## Setting up Open DNS 

1. Create an [Open DNS](https://www.opendns.com/) account.
2. Add a network to your account - this will use you current external ip address.
3. Download the [OpenDNS Dynamic IP Upater](https://support.opendns.com/hc/en-us/articles/227987867-What-is-the-OpenDNS-Dynamic-IP-updater-client-) - set the Network to update to the network in OpenDNS. Click Settings (bottom right) and make sure **Send DNS-O-Matic updates** is checked. 

## Setting up DNS-O-Matic

1. Create an account on [DNS-O-Matic](https://www.dnsomatic.com/).
2. Setup a service to update your [cloudflare account](https://support.cloudflare.com/hc/en-us/articles/360020524512-Manage-dynamic-IPs-in-Cloudflare-DNS-programmatically).
