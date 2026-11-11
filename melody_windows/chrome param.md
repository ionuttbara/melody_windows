setx CHROME_FLAGS "--disable-background-networking --disable-dev-shm-usage --disable-geolocation --disable-hardware-noise-reduction --disable-infobars --disable-logging --disable-plugins --disable-predictive-networking-use --disable-render-throttling --disable-ssl-false-start --disable-session-crashed-bubble --disable-smooth-scrolling --disable-gpu-driver-bug-workarounds --disable-gpu-vsync --dns-prefetch-disable --enable-gpu-rasterization --enable-lazy-image-loading --enable-lite-video --enable-features=UseGpuScheduler --enable-parallel-downloading --enable-quic --enable-zero-copy --ignore-certificate-errors --no-default-browser-check --no-pings --process-per-site --safebrowsing-disable-download-protection --zero-copy" /M


start chrome %CHROME_FLAGS%
