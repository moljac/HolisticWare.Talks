#!/bin/bash

sharpie \
    --help

sharpie \
    xcode \
        --help

sharpie \
    xcode \
        --sdks
        
        
open ./ConnectIQ.framework/Info.plist
		
sharpie \
    bind \
        --verbose \
        -output ./Xamarin.iOS.Sharpie/ \
        -sdk iphoneos10.3 \
        -n Garmin.ConnectIQ \
        --framework ./ConnectIQ.framework \
        -c -F. -v        