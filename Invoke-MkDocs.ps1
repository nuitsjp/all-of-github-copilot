# Material for MkDocsを起動するスクリプト

param(
    [string]$Port = "8000",
    [string]$Address = "127.0.0.1",
    [switch]$WithUpdate
)

# エラー時に停止
$ErrorActionPreference = "Stop"

# スクリプトのディレクトリを取得
$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
Set-Location $ScriptDir

# 仮想環境のパス
$VenvPath = Join-Path $ScriptDir ".venv"

Write-Host "=== Material for MkDocs セットアップ ===" -ForegroundColor Green

# パッケージインストールが必要かどうかのフラグ
$NeedPackageInstall = $false

# WithUpdateオプションが指定された場合、既存の仮想環境を削除
if ($WithUpdate -and (Test-Path $VenvPath)) {
    Write-Host "WithUpdateオプションが指定されました。既存の仮想環境を削除中..." -ForegroundColor Yellow
    Remove-Item $VenvPath -Recurse -Force
    Write-Host "既存の仮想環境を削除しました。" -ForegroundColor Green
    $NeedPackageInstall = $true
}

# Python仮想環境の確認・作成
if (-not (Test-Path $VenvPath)) {
    Write-Host "Python仮想環境を作成中..." -ForegroundColor Yellow
    python -m venv $VenvPath
    if ($LASTEXITCODE -ne 0) {
        Write-Error "Python仮想環境の作成に失敗しました。Pythonがインストールされているか確認してください。"
    }
    Write-Host "Python仮想環境を作成しました。" -ForegroundColor Green
    $NeedPackageInstall = $true
} else {
    Write-Host "Python仮想環境が見つかりました。" -ForegroundColor Green
}

# 仮想環境をアクティベート
$ActivateScript = Join-Path $VenvPath "Scripts\Activate.ps1"
if (Test-Path $ActivateScript) {
    Write-Host "仮想環境をアクティベート中..." -ForegroundColor Yellow
    & $ActivateScript
} else {
    Write-Error "仮想環境のアクティベートスクリプトが見つかりません。"
}

# mkdocs.ymlの存在確認
$MkDocsConfig = Join-Path $ScriptDir "mkdocs.yml"
if (-not (Test-Path $MkDocsConfig)) {
    Write-Error "mkdocs.yml が見つかりません。"
}

# 必要なパッケージのインストール（新規作成時のみ）
if ($NeedPackageInstall) {
    Write-Host "必要なパッケージをインストール中..." -ForegroundColor Yellow

    # 必要なパッケージを直接指定
    $RequiredPackages = @(
        "mkdocs",
        "mkdocs-material",
        "mkdocs-open-in-new-tab",
        "mkdocs-awesome-pages-plugin",
        "pymdown-extensions"
    )

    foreach ($Package in $RequiredPackages) {
        Write-Host "インストール中: $Package" -ForegroundColor Cyan
        pip install $Package --quiet
        if ($LASTEXITCODE -ne 0) {
            Write-Warning "パッケージ '$Package' のインストールに失敗しました。"
        }
    }

    Write-Host "パッケージのインストールが完了しました。" -ForegroundColor Green
} else {
    Write-Host "既存の仮想環境を使用します。パッケージインストールをスキップします。" -ForegroundColor Green
}

# MkDocsサーバーを起動
Write-Host "=== MkDocsサーバーを起動します ===" -ForegroundColor Green
Write-Host "アクセスURL: http://$Address`:$Port" -ForegroundColor Cyan
Write-Host "停止するには Ctrl+C を押してください。" -ForegroundColor Yellow
Write-Host ""

try {
    mkdocs serve --dev-addr "$Address`:$Port"
} catch {
    Write-Error "MkDocsサーバーの起動に失敗しました: $_"
} finally {
    Write-Host "MkDocsサーバーを停止しました。" -ForegroundColor Yellow
}
