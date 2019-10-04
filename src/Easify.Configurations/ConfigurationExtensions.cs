// This software is part of the Easify framework
// Copyright (C) 2019 Intermediate Capital Group
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using Microsoft.Extensions.Configuration;

namespace Easify.Configurations
{
    public static class ConfigurationExtensions
    {
        public static AppInfo GetApplicationInfo(this IConfiguration config)
        {
            var name = config[ConfigurationKeys.AppTitleKey];
            var version = config[ConfigurationKeys.AppVersionKey];
            var environment = config[ConfigurationKeys.AppEnvironmentNameKey];

            return new AppInfo(name, version, environment);
        }
    }
}