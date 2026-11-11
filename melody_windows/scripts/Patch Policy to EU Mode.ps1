$numeFisier = "IntegratedServicesRegionPolicySet.json"
$locatieCurenta = "C:\\Windows\\System32"

Write-Host "Caut fisierul '$numeFisier' in folderul curent si subfoldere..." -ForegroundColor Cyan
$fisierGasit = Get-ChildItem -Path $locatieCurenta -Filter $numeFisier -Recurse -ErrorAction SilentlyContinue | Select-Object -First 1

if ($fisierGasit) {
    Write-Host "Fisier gasit: $($fisierGasit.FullName)" -ForegroundColor Green
    $continut = Get-Content $fisierGasit.FullName -Raw
    if ($continut -match '"BE"') {
        Write-Host "Am gasit 'BE'. Se inlocuieste cu 'US'..." -ForegroundColor Yellow
        $continutNou = $continut -replace '"BE"', '"US"'
        Set-Content -Path $fisierGasit.FullName -Value $continutNou -Encoding UTF8
    } else {
        Write-Host "Fisierul a fost gasit, dar nu contine 'BE' (poate a fost deja modificat)." -ForegroundColor Magenta
    }
} else {
    Write-Host "EROARE: Fisierul nu a fost gasit in acest folder." -ForegroundColor Red}

Write-Host "Apasa ENTER pentru a inchide..."