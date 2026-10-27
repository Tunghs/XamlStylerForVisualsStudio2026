# XAML Styler for Visual Studio 2026

[한국어](#한국어) | [English](#english)

> [!IMPORTANT]
> This is an unofficial, community-maintained fork of [Xavalon/XamlStyler](https://github.com/Xavalon/XamlStyler). It is not affiliated with or endorsed by Xavalon or the upstream maintainers.

## 한국어

### 소개

XAML Styler for Visual Studio 2026은 XAML 파일을 일관된 규칙에 따라 정렬하고 서식을 지정하는 Visual Studio 확장입니다. 이 저장소는 원본 [XAML Styler](https://github.com/Xavalon/XamlStyler)를 기반으로 Visual Studio 2026에서 설치하고 사용할 수 있도록 구성한 비공식 포크입니다.

이 포크에서 적용한 주요 변경 사항은 다음과 같습니다.

- Visual Studio 2026에서 설치 가능한 별도 VSIX ID와 패키지 GUID
- 사용자 단위 설치
- 활성 XAML 편집기에서 확장 패키지 자동 로드
- Visual Studio 2026용 빌드 출력과 메타데이터
- 최신 `Newtonsoft.Json` 의존성 적용

### 설치

1. 저장소의 [Releases](https://github.com/Tunghs/XamlStylerForVisualsStudio2026/releases)에서 최신 `.vsix` 파일을 내려받습니다.
2. 실행 중인 Visual Studio 인스턴스를 모두 종료합니다.
3. 내려받은 `.vsix` 파일을 실행하고 설치 대상 Visual Studio를 선택합니다.
4. Visual Studio를 다시 실행합니다.

공식 XAML Styler와 이 포크는 같은 명령과 설정 페이지를 제공하므로 동일한 Visual Studio 인스턴스에서 두 확장을 동시에 활성화하지 않는 것을 권장합니다.

### 사용법

XAML 편집기 또는 솔루션 탐색기에서 대상 파일을 마우스 오른쪽 버튼으로 클릭한 후 **Format XAML**을 선택합니다. 기본 단축키는 `Ctrl+K, Ctrl+2`입니다.

설정은 Visual Studio의 **Tools > Options > XAML Styler**에서 변경할 수 있습니다. 포맷 규칙에 대한 자세한 설명은 [원본 프로젝트 문서](https://github.com/Xavalon/XamlStyler/wiki)를 참고하세요.

### 호환성과 검증

- Visual Studio 2026 Professional 18.5.2, Windows x64에서 설치 및 패키지 로드를 확인했습니다.
- 확장은 Visual Studio의 안정적인 17.x 확장 API를 대상으로 합니다.
- 포맷 엔진 단위 테스트 471개가 통과했습니다.
- amd64 및 arm64 설치 대상을 포함합니다.

### 개발 및 빌드

필요 환경:

- Visual Studio 2026
- Visual Studio extension development 워크로드
- .NET 8 SDK

`src/XamlStyler.sln`을 열고 `XamlStyler.Extension.Windows.VS2026` 프로젝트를 시작 프로젝트로 설정한 후 `F5`를 누르면 실험적 Visual Studio 인스턴스가 실행됩니다.

Release VSIX 빌드:

```powershell
msbuild src\XamlStyler.Extension.Windows.VS2022\XamlStyler.Extension.Windows.VS2022.csproj /restore /t:Rebuild /p:Configuration=Release /p:Platform=AnyCPU
```

생성 위치:

```text
src/bin/Release/Extension.Windows.VS2026/XamlStyler.Extension.Windows.VS2026.vsix
```

테스트:

```powershell
dotnet test src\XamlStyler.UnitTests\XamlStyler.UnitTest.csproj --configuration Release
```

### 라이선스 및 저작권 고지

이 프로젝트는 [Apache License 2.0](LICENSE)에 따라 배포됩니다.

- 원본 프로젝트: [Xavalon/XamlStyler](https://github.com/Xavalon/XamlStyler)
- 원본 코드의 저작권은 Xavalon 및 각 XAML Styler 기여자에게 있습니다.
- 이 포크의 변경 사항에 대한 저작권은 Tunghs 및 해당 변경 사항의 기여자에게 있습니다.
- 변경 및 출처에 대한 추가 고지는 [NOTICE](NOTICE)를 참고하세요.
- `XAML Styler`, `Visual Studio` 및 기타 제품명과 상표는 각 소유자에게 귀속됩니다. 프로젝트 이름은 원본과 호환 대상을 설명하기 위한 용도로만 사용됩니다.

Apache License 2.0에 따라 소프트웨어는 명시적 또는 묵시적 보증 없이 **있는 그대로(AS IS)** 제공됩니다.

---

## English

### Overview

XAML Styler for Visual Studio 2026 is a Visual Studio extension that formats and organizes XAML files according to configurable styling rules. This repository is an unofficial fork of the original [XAML Styler](https://github.com/Xavalon/XamlStyler), packaged and verified for use with Visual Studio 2026.

The main changes in this fork are:

- A separate VSIX identity and package GUIDs for the Visual Studio 2026 distribution
- Per-user installation
- Automatic package loading when a XAML editor is active
- Visual Studio 2026 build output and metadata
- An updated `Newtonsoft.Json` dependency

### Installation

1. Download the latest `.vsix` file from [Releases](https://github.com/Tunghs/XamlStylerForVisualsStudio2026/releases).
2. Close all running Visual Studio instances.
3. Run the downloaded `.vsix` file and select the target Visual Studio installation.
4. Restart Visual Studio.

The official XAML Styler extension and this fork expose the same commands and settings pages. Enabling both editions in the same Visual Studio instance is not recommended.

### Usage

Right-click a target file in the XAML editor or Solution Explorer and select **Format XAML**. The default keyboard shortcut is `Ctrl+K, Ctrl+2`.

Settings are available under **Tools > Options > XAML Styler**. See the [upstream documentation](https://github.com/Xavalon/XamlStyler/wiki) for details about formatting rules.

### Compatibility and verification

- Installation and package loading were verified on Visual Studio 2026 Professional 18.5.2 on Windows x64.
- The extension targets the stable Visual Studio 17.x extension API surface.
- All 471 formatter unit tests pass.
- The VSIX contains amd64 and arm64 installation targets.

### Development and build

Requirements:

- Visual Studio 2026
- Visual Studio extension development workload
- .NET 8 SDK

Open `src/XamlStyler.sln`, set `XamlStyler.Extension.Windows.VS2026` as the startup project, and press `F5` to launch an experimental Visual Studio instance.

Build the Release VSIX:

```powershell
msbuild src\XamlStyler.Extension.Windows.VS2022\XamlStyler.Extension.Windows.VS2022.csproj /restore /t:Rebuild /p:Configuration=Release /p:Platform=AnyCPU
```

Output:

```text
src/bin/Release/Extension.Windows.VS2026/XamlStyler.Extension.Windows.VS2026.vsix
```

Run the tests:

```powershell
dotnet test src\XamlStyler.UnitTests\XamlStyler.UnitTest.csproj --configuration Release
```

### License and attribution

This project is distributed under the [Apache License 2.0](LICENSE).

- Upstream project: [Xavalon/XamlStyler](https://github.com/Xavalon/XamlStyler)
- Copyright in the upstream code remains with Xavalon and the respective XAML Styler contributors.
- Copyright in modifications made by this fork remains with Tunghs and the respective contributors to those modifications.
- See [NOTICE](NOTICE) for additional attribution and modification notices.
- `XAML Styler`, `Visual Studio`, and other product names and trademarks belong to their respective owners. They are used only to identify the upstream work and the intended compatibility target.

As required by the Apache License 2.0, the software is provided on an **AS IS** basis, without warranties or conditions of any kind.

## Upstream resources

- [Upstream repository](https://github.com/Xavalon/XamlStyler)
- [Documentation](https://github.com/Xavalon/XamlStyler/wiki)
- [Upstream releases](https://github.com/Xavalon/XamlStyler/releases)
- [Contributing guide](https://github.com/Xavalon/XamlStyler/blob/master/CONTRIBUTING.md)
