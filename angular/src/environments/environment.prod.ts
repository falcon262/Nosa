import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44335/',
  redirectUri: baseUrl,
  clientId: 'Nosa_App',
  responseType: 'code',
  scope: 'offline_access Nosa',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Nosa',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44335',
      rootNamespace: 'PwC.Nosa',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
